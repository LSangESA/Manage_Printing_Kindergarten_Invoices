namespace QL_Thu_HP
{
    partial class fCapNhatKhoanThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.nudMucThu = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKhoanThu = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gpbKhoanThu = new System.Windows.Forms.GroupBox();
            this.dgvMucThu = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTimKhoanThu = new System.Windows.Forms.Button();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMucThu)).BeginInit();
            this.gpbKhoanThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMucThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.nudMucThu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbKhoanThu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbKhoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 380);
            this.panel1.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 380);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // nudMucThu
            // 
            this.nudMucThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMucThu.Location = new System.Drawing.Point(152, 332);
            this.nudMucThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMucThu.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMucThu.Name = "nudMucThu";
            this.nudMucThu.Size = new System.Drawing.Size(243, 30);
            this.nudMucThu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mức thu:";
            // 
            // lbKhoanThu
            // 
            this.lbKhoanThu.DisplayMember = "Chọn...";
            this.lbKhoanThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoanThu.FormattingEnabled = true;
            this.lbKhoanThu.ItemHeight = 22;
            this.lbKhoanThu.Location = new System.Drawing.Point(152, 110);
            this.lbKhoanThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKhoanThu.Name = "lbKhoanThu";
            this.lbKhoanThu.Size = new System.Drawing.Size(243, 180);
            this.lbKhoanThu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoản thu:";
            // 
            // cbKhoi
            // 
            this.cbKhoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKhoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(152, 62);
            this.cbKhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(243, 30);
            this.cbKhoi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khối:";
            // 
            // cbNam
            // 
            this.cbNam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "Chọn..."});
            this.cbNam.Location = new System.Drawing.Point(152, 23);
            this.cbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(243, 30);
            this.cbNam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 513);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gpbKhoanThu
            // 
            this.gpbKhoanThu.BackColor = System.Drawing.SystemColors.Control;
            this.gpbKhoanThu.Controls.Add(this.panel1);
            this.gpbKhoanThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbKhoanThu.Location = new System.Drawing.Point(12, 12);
            this.gpbKhoanThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbKhoanThu.Name = "gpbKhoanThu";
            this.gpbKhoanThu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbKhoanThu.Size = new System.Drawing.Size(428, 418);
            this.gpbKhoanThu.TabIndex = 8;
            this.gpbKhoanThu.TabStop = false;
            this.gpbKhoanThu.Text = "Mức thu";
            // 
            // dgvMucThu
            // 
            this.dgvMucThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMucThu.Location = new System.Drawing.Point(465, 66);
            this.dgvMucThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMucThu.Name = "dgvMucThu";
            this.dgvMucThu.RowTemplate.Height = 24;
            this.dgvMucThu.Size = new System.Drawing.Size(583, 422);
            this.dgvMucThu.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 446);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(125, 446);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 42);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(232, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(339, 446);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 42);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Làm mới";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(661, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 30);
            this.txtSearch.TabIndex = 11;
            // 
            // btnTimKhoanThu
            // 
            this.btnTimKhoanThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKhoanThu.Location = new System.Drawing.Point(834, 18);
            this.btnTimKhoanThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKhoanThu.Name = "btnTimKhoanThu";
            this.btnTimKhoanThu.Size = new System.Drawing.Size(75, 36);
            this.btnTimKhoanThu.TabIndex = 12;
            this.btnTimKhoanThu.Text = "Tìm";
            this.btnTimKhoanThu.UseVisualStyleBackColor = true;
            this.btnTimKhoanThu.Click += new System.EventHandler(this.btnTimKhoanThu_Click);
            // 
            // txtMaMT
            // 
            this.txtMaMT.Location = new System.Drawing.Point(1301, 231);
            this.txtMaMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.ReadOnly = true;
            this.txtMaMT.Size = new System.Drawing.Size(100, 22);
            this.txtMaMT.TabIndex = 13;
            // 
            // fCapNhatKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 513);
            this.Controls.Add(this.txtMaMT);
            this.Controls.Add(this.btnTimKhoanThu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMucThu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gpbKhoanThu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fCapNhatKhoanThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Mức thu";
            this.Load += new System.EventHandler(this.fCapNhatKhoanThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMucThu)).EndInit();
            this.gpbKhoanThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMucThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbKhoanThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMucThu;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gpbKhoanThu;
        private System.Windows.Forms.DataGridView dgvMucThu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTimKhoanThu;
        private System.Windows.Forms.TextBox txtMaMT;
    }
}