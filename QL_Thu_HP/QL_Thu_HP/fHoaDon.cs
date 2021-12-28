using Microsoft.Reporting.WinForms;
using QL_Thu_HP.DAO;
using QL_Thu_HP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace QL_Thu_HP
{
    public partial class fHoaDon : Form
    {
        string namHoc = fLapPhieuThu.NgayGio;
        string khoi = fLapPhieuThu.Khoi;
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void fTestHoaDon_Load(object sender, EventArgs e)
        {
            CreatePannal();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        public void CreatePannal()
        {
            int layout = 30;
            fHoaDon fhd = new fHoaDon();
            int maxWith = fhd.Width - 90;
            int i = 0;
            string queryC = string.Format("SELECT t.TEN_TRE, t.TEN_LOP, l.TEN_KHOI FROM dbo.TRE_EM t, dbo.LOP l WHERE t.TEN_LOP = l.TEN_LOP AND l.TEN_KHOI = N'{0}'", fLapPhieuThu.Khoi);
            DataTable count = DataProvide.Instance.ExecuteQuery(queryC);
            string querySum = string.Format("SELECT SUM(GIA_MUC_THU) FROM dbo.MUC_THU WHERE TEN_KHOI = N'{0}' AND NAM_THU = '{1}'", khoi, namHoc);
            int sumKT = Convert.ToInt32(DataProvide.Instance.ExecuteScalar(querySum));
            int n = 1;
            foreach(DataRow item in count.Rows)
            {
                // Pannel
                Panel pn = new Panel();
                pn.BackColor = Color.Wheat;
                pn.Location = new System.Drawing.Point(30, layout);
                pn.Size = new System.Drawing.Size(maxWith, 480);
                pn.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(pn);
                layout += 480;

                // labelTitle
                Label lbTitle = new Label();
                lbTitle.Name = "txtTitle";
                lbTitle.Text = "HÓA ĐƠN";
                lbTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lbTitle.AutoSize = true;
                lbTitle.Location = new Point(220, 20);

                // labelSoHoaDon
                Label lbSoHoaDon = new Label();
                lbSoHoaDon.Name = "txtSoHoaDon";
                lbSoHoaDon.Text = "Số hóa đơn: " + n++;
                lbSoHoaDon.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lbSoHoaDon.AutoSize = true;
                lbSoHoaDon.Location = new Point(400, 20);

                // labelNgaylap
                Label lbNgayLap = new Label();
                lbNgayLap.Name = "txtNgayLap";
                lbNgayLap.Text = "Ngày lập: " + DateTime.Now.ToShortDateString();
                lbNgayLap.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                lbNgayLap.AutoSize = true;
                lbNgayLap.Location = new Point(400, 45);

                // labelHoTenTre
                Label lbHoTen = new Label();
                lbHoTen.Name = "txtHoTen";
                lbHoTen.Text = "Họ và tên: " + item.ItemArray[i].ToString().ToUpper();
                lbHoTen.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lbHoTen.AutoSize = true;
                lbHoTen.Location = new Point(90, 70);

                // labelLop
                Label lbLop = new Label();
                lbLop.Name = "txtLop";
                lbLop.Text = "Lớp: " + item.ItemArray[i+1].ToString();
                lbLop.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lbLop.AutoSize = true;
                lbLop.Location = new Point(90, 110);

                // labelkhoi
                Label lbKhoi = new Label();
                lbKhoi.Name = "txtKhoi";
                lbKhoi.Text = "Khối: " + item.ItemArray[i+2].ToString();
                lbKhoi.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lbKhoi.AutoSize = true;
                lbKhoi.Location = new Point(90, 150);

                // labelNguoiThu
                Label lbNT = new Label();
                lbNT.Text = "Người thu tiền";
                lbNT.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lbNT.AutoSize = true;
                lbNT.Location = new Point(420, 380);

                // labelNguoiNop
                Label lbNN = new Label();
                lbNN.Text = "Người nộp tiền";
                lbNN.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lbNN.AutoSize = true;
                lbNN.Location = new Point(90, 380);

                ListView lv = new ListView();
                lv.View = View.Details;
                lv.GridLines = true;
                lv.Location = new Point(40, 190);
                lv.Size = new Size(maxWith - 80, 130);
                string queryS = string.Format("SELECT TEN_KT AS [KHOẢN THU], GIA_MUC_THU AS [GIÁ] FROM dbo.MUC_THU WHERE TEN_KHOI = N'{0}' AND NAM_THU = '{1}'", khoi, namHoc);
                DataTable data = new DataTable();
                data = DataProvide.Instance.ExecuteQuery(queryS);
                lv.Columns.Add("KHOẢN THU");
                lv.Columns.Add("GIÁ");
                foreach (DataRow itemKT in data.Rows)
                {
                    CultureInfo culture = new CultureInfo("vi-VN");

                    //Thread.CurrentThread.CurrentCulture = culture;

                    int layGia = Convert.ToInt32(itemKT.ItemArray[1].ToString());
                    string gia = layGia.ToString("0,0 đ", culture);

                    ListViewItem item1 = new ListViewItem();
                    item1.Text = itemKT.ItemArray[0].ToString();
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia });

                    lv.Items.Add(item1);

                }
                
                //labelTongTien
                Label lbTongTien = new Label();
                CultureInfo tongTien = new CultureInfo("vi-VN");
                string TT = sumKT.ToString("0,0 đ", tongTien);
                lbTongTien.Text = "Tổng tiền: " + TT;
                lbTongTien.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lbTongTien.AutoSize = true;
                lbTongTien.Location = new Point(400, 330);

                pn.Controls.Add(lbTitle);
                pn.Controls.Add(lbSoHoaDon);
                pn.Controls.Add(lbNgayLap);
                pn.Controls.Add(lbHoTen);
                pn.Controls.Add(lbLop);
                pn.Controls.Add(lbKhoi);
                pn.Controls.Add(lbNT);
                pn.Controls.Add(lbNN);
                pn.Controls.Add(lv);
                pn.Controls.Add(lbTongTien);
                lv.Columns[0].Width = 290;
                lv.Columns[1].Width = 200;
                SetHeight(lv, 33);
            }
        }


    }
}
