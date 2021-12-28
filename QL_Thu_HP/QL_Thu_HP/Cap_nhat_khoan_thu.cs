using QL_Thu_HP.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_Thu_HP
{
    public partial class fCapNhatKhoanThu : Form
    {
        BindingSource listMucThu = new BindingSource();

        public fCapNhatKhoanThu()
        {
            InitializeComponent();
        }

        #region Methods

        public void loadBindingSource()
        {
            dgvMucThu.DataSource = listMucThu;
        }

        public void LoadNamKhoanThu()
        {
            string query = "SELECT * FROM dbo.NAM";
            cbNam.DataSource = DataProvide.Instance.ExecuteQuery(query);
            cbNam.DisplayMember = "NAM";
        }

        public void LoadKhoiHoc()
        {
            string query = "SELECT * FROM KHOI";
            cbKhoi.DataSource = DataProvide.Instance.ExecuteQuery(query);
            cbKhoi.DisplayMember = "TEN_KHOI";
        }

        public void LoadKhoanThu()
        {
            string query = "SELECT * FROM KHOAN_THU";
            lbKhoanThu.DataSource = DataProvide.Instance.ExecuteQuery(query);
            lbKhoanThu.DisplayMember = "TEN_KT";
        }

        public void LoadListMucThu()
        {
            string query = "SELECT NAM_THU AS [Năm học], TEN_KHOI AS [Khối học], TEN_KT AS [Khoản thu], GIA_MUC_THU AS [Giá thu], MA_MT AS [id] FROM dbo.MUC_THU ORDER BY NAM_THU DESC;";
            listMucThu.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }

        public bool AddMucThu(string khoi, int nam, string khoanThu, int mucThu)
        {
            string query = "EXEC dbo.SP_AddMucThu @Nam , @Khoi , @KhoanThu , @GiaThu";
            int result = DataProvide.Instance.ExecuteNonQuery(query, new object[] { nam, khoi, khoanThu, mucThu });

            return result > 0;
        }

        public void ExecAddMucThu()
        {
            string tenKhoi = cbKhoi.Text.ToString();
            int namThu = Convert.ToInt32(cbNam.Text.ToString());
            string khoanThu = lbKhoanThu.Text.ToString();
            int mucThu = Convert.ToInt32(nudMucThu.Value);

            DataTable soDong = CheckDongTraVeMucThu(namThu, khoanThu, tenKhoi);
            int countDongTraVe = 0;

            string messError = string.Format("Đã tồn tại khoản thu {0} của khối {1} vào năm {2}", khoanThu.ToUpper(), tenKhoi.ToUpper(), namThu);

            foreach(DataRow item in soDong.Rows)
            {
                countDongTraVe += Convert.ToInt32(item.ItemArray[0].ToString());
            }

            if (countDongTraVe >= 1)
            {
                MessageBox.Show(messError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (AddMucThu(tenKhoi, namThu, khoanThu, mucThu))
                {
                    LoadListMucThu();
                    cbKhoi.Text = tenKhoi.ToString();
                    cbNam.Text = namThu.ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataTable CheckDongTraVeMucThu(int nam, string khoanThu, string khoi)
        {
            DataTable count = new DataTable();
            string query = "EXEC dbo.SP_KiemTraKhoanThuTonTai @Nam , @KhoanThu , @Khoi";
            count = DataProvide.Instance.ExecuteQuery(query, new object[] { nam, khoanThu , khoi});

            return count;
        }

        public bool DeleteKhoanThu(int nam, string khoanThu, string khoi)
        {
            string query = string.Format("DELETE dbo.MUC_THU WHERE NAM_THU = {0} AND TEN_KT = N'{1}' AND TEN_KHOI = N'{2}'", nam, khoanThu, khoi);
            int result = DataProvide.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void ExecDeleteKhoanThu()
        {
            string tenKhoi = cbKhoi.Text.ToString();
            int namThu = Convert.ToInt32(cbNam.Text.ToString());
            string khoanThu = lbKhoanThu.Text.ToString();

            if(DeleteKhoanThu(namThu,khoanThu,tenKhoi))
            {
                LoadListMucThu();
            }
            else
            {
                MessageBox.Show("Lỗi thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool UpdateKhoanThu(int mucThu, int nam, string khoanThu, string khoi, int maMT)
        {
            string query = string.Format("UPDATE dbo.MUC_THU SET GIA_MUC_THU = {0}, NAM_THU = {1}, TEN_KT = N'{2}', TEN_KHOI = N'{3}' WHERE MA_MT = {4}",
                mucThu, nam, khoanThu, khoi, maMT);
            int result = DataProvide.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void ExecUpdateKhoanThu()
        {
            int maMT = Convert.ToInt32(txtMaMT.Text.ToString());
            string tenKhoi = cbKhoi.Text.ToString();
            int namThu = Convert.ToInt32(cbNam.Text.ToString());
            string khoanThu = lbKhoanThu.Text.ToString();
            int mucThu = Convert.ToInt32(nudMucThu.Value);

            if (UpdateKhoanThu(mucThu, namThu, khoanThu, tenKhoi, maMT))
            {
                LoadListMucThu();
            }
            else
            {
                MessageBox.Show("Lỗi thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AddMucThuBinding()
        {
            nudMucThu.DataBindings.Add(new Binding("Value", listMucThu, "Giá thu"));
            cbKhoi.DataBindings.Add(new Binding("Text", listMucThu, "Khối học"));
            cbNam.DataBindings.Add(new Binding("Text", listMucThu, "Năm học"));
            lbKhoanThu.DataBindings.Add(new Binding("Text", listMucThu, "Khoản thu"));
            txtMaMT.DataBindings.Add(new Binding("Text", listMucThu, "id"));
        }

        public DataTable SearchKhoanThu(string tenKT)
        {
            string query = string.Format("SELECT NAM_THU AS [Năm học], TEN_KHOI AS [Khối học], TEN_KT AS [Khoản thu], GIA_MUC_THU AS [Giá thu], MA_MT AS [id] FROM MUC_THU WHERE dbo.fuConvertToUnsign1(NAM_THU) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + N'%' OR dbo.fuConvertToUnsign1(TEN_KHOI) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + N'%' OR dbo.fuConvertToUnsign1(TEN_KT) LIKE N'%' + dbo.fuConvertToUnsign1(N'{2}') + N'%' OR dbo.fuConvertToUnsign1(GIA_MUC_THU) LIKE N'%' + dbo.fuConvertToUnsign1(N'{3}') + N'%'", tenKT, tenKT, tenKT, tenKT);
            DataTable data = DataProvide.Instance.ExecuteQuery(query);

            return data;
        }

        public void LoadSearchMucThu()
        {
            listMucThu.DataSource = SearchKhoanThu(txtSearch.Text.ToString());
        }
        #endregion

        #region Events

        private void fCapNhatKhoanThu_Load(object sender, EventArgs e)
        {
            LoadNamKhoanThu();
            LoadKhoiHoc();
            LoadKhoanThu();
            loadBindingSource();
            LoadListMucThu();
            AddMucThuBinding();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExecAddMucThu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExecDeleteKhoanThu();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExecUpdateKhoanThu();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListMucThu();
        }

        private void btnTimKhoanThu_Click(object sender, EventArgs e)
        {
            LoadSearchMucThu();
        }

        #endregion











    }
}
