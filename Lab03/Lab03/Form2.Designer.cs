namespace Lab03
{
    partial class frmThemSV
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
            label1 = new System.Windows.Forms.Label();
            cboKhoa = new System.Windows.Forms.ComboBox();
            txtTenSV = new System.Windows.Forms.TextBox();
            txtMaSV = new System.Windows.Forms.TextBox();
            txtDiemTB = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnThem = new DevExpress.XtraEditors.SimpleButton();
            btnXoa = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(155, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Ngôn Ngữ Anh", "Quản Trị Kinh Doanh" });
            cboKhoa.Location = new System.Drawing.Point(407, 205);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new System.Drawing.Size(213, 28);
            cboKhoa.TabIndex = 1;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new System.Drawing.Point(407, 123);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new System.Drawing.Size(165, 27);
            txtTenSV.TabIndex = 2;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new System.Drawing.Point(407, 48);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new System.Drawing.Size(165, 27);
            txtMaSV.TabIndex = 2;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new System.Drawing.Point(407, 299);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new System.Drawing.Size(125, 27);
            txtDiemTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(155, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(155, 207);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 22);
            label3.TabIndex = 0;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(155, 299);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 22);
            label4.TabIndex = 0;
            label4.Text = "Điểm TB";
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(178, 373);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(118, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(454, 373);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(118, 36);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            // 
            // frmThemSV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDiemTB);
            Controls.Add(txtMaSV);
            Controls.Add(txtTenSV);
            Controls.Add(cboKhoa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmThemSV";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}