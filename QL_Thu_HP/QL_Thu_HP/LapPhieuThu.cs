using QL_Thu_HP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_Thu_HP
{
    public partial class fLapPhieuThu : Form
    {
        private static string ngayGio;

        public static string NgayGio
        {
            get { return fLapPhieuThu.ngayGio; }
            set { fLapPhieuThu.ngayGio = value; }
        }
        private static string khoi;

        public static string Khoi
        {
            get { return fLapPhieuThu.khoi; }
            set { fLapPhieuThu.khoi = value; }
        }

        public fLapPhieuThu()
        {
            InitializeComponent();
        }

        #region Methods
        
        public void LoadKhoi()
        {
            string query = "select * from khoi";
            cbKhoi.DataSource = DataProvide.Instance.ExecuteQuery(query);
            cbKhoi.DisplayMember = "TEN_KHOI";
        }

        public void EditWidthTable()
        {
            dgvTreEm.Columns[0].Width = 100;
            dgvTreEm.Columns[1].Width = 190;
            dgvTreEm.Columns[2].Width = 93;
        }

        public DataTable GetListTreEm()
        {
            string query = "select MA_TRE AS [MÃ TRẺ], TEN_TRE AS [TÊN TRẺ], TEN_LOP AS [TÊN LỚP] from Tre_Em";
            DataTable data = DataProvide.Instance.ExecuteQuery(query);

            return data;
        }

        public void LoadListTreEm()
        {
            dgvTreEm.DataSource = GetListTreEm();
        }

        public void LoadNam()
        {
            //string layNgay = DateTime.Now.ToShortDateString();
            //txtNgaylap.Text = layNgay;
            cbNamHoc.DataSource = DataProvide.Instance.ExecuteQuery("select * from nam");
            cbNamHoc.DisplayMember = "NAM";
            cbNamHoc.Text = "2020";
        }

        #endregion

        private void fLapPhieuThu_Load(object sender, EventArgs e)
        {
            LoadNam();
            LoadKhoi();
            LoadListTreEm();
            EditWidthTable();
            NgayGio = cbNamHoc.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fHoaDon fXDH = new fHoaDon();
            this.Hide();
            fXDH.ShowDialog();
            this.Show();
        }


        public void LoadListTreEmWhenSelect()
        {
            NgayGio = cbNamHoc.Text.ToString();
            Khoi = cbKhoi.Text.ToString();
            string query = string.Format("SELECT t.MA_TRE, t.TEN_TRE, t.TEN_LOP FROM dbo.TRE_EM t, dbo.LOP l WHERE t.TEN_LOP = l.TEN_LOP AND l.TEN_KHOI = N'{0}'", khoi);
            dgvTreEm.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListTreEmWhenSelect();
        }
    }
}
