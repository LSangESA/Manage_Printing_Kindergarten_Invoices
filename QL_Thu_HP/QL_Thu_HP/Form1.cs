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
    public partial class fQuanLy : Form
    {

        public fQuanLy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fCapNhatKhoanThu fKT = new fCapNhatKhoanThu();
            this.Hide();
            fKT.ShowDialog();
            this.Show();
        }

        private void fQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fLapPhieuThu fPT = new fLapPhieuThu();
            this.Hide();
            fPT.ShowDialog();
            this.Show();
            
        }
    }
}
