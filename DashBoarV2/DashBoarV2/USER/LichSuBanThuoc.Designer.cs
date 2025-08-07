namespace DashBoarV2.USER
{
    partial class LichSuBanThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSalesHistory = new System.Windows.Forms.DataGridView();
            lblPhieuNhap = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            btnXemChiTiet = new System.Windows.Forms.Button();
            txtTimKiemHoaDon = new System.Windows.Forms.TextBox();
            btnTìm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesHistory).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvSalesHistory
            // 
            dgvSalesHistory.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesHistory.Location = new System.Drawing.Point(104, 211);
            dgvSalesHistory.Name = "dgvSalesHistory";
            dgvSalesHistory.RowHeadersWidth = 51;
            dgvSalesHistory.Size = new System.Drawing.Size(1426, 564);
            dgvSalesHistory.TabIndex = 7;
            dgvSalesHistory.CellContentClick += dgvSalesHistory_CellContentClick;
            // 
            // lblPhieuNhap
            // 
            lblPhieuNhap.AutoSize = true;
            lblPhieuNhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblPhieuNhap.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPhieuNhap.Location = new System.Drawing.Point(134, 28);
            lblPhieuNhap.Name = "lblPhieuNhap";
            lblPhieuNhap.Size = new System.Drawing.Size(332, 41);
            lblPhieuNhap.TabIndex = 4;
            lblPhieuNhap.Text = "Lịch Sử Bán Thuốc";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPhieuNhap);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(58, 28);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(473, 101);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.package_receipt1;
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(107, 95);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1151, 161);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 20);
            label1.TabIndex = 12;
            label1.Text = "Tìm Kiếm";
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.BackColor = System.Drawing.Color.DodgerBlue;
            btnXemChiTiet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnXemChiTiet.Location = new System.Drawing.Point(1393, 781);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new System.Drawing.Size(137, 41);
            btnXemChiTiet.TabIndex = 14;
            btnXemChiTiet.Text = "Xem Chi Tiết";
            btnXemChiTiet.UseVisualStyleBackColor = false;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // txtTimKiemHoaDon
            // 
            txtTimKiemHoaDon.Location = new System.Drawing.Point(1238, 158);
            txtTimKiemHoaDon.Multiline = true;
            txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            txtTimKiemHoaDon.Size = new System.Drawing.Size(227, 28);
            txtTimKiemHoaDon.TabIndex = 15;
            // 
            // btnTìm
            // 
            btnTìm.BackColor = System.Drawing.Color.DodgerBlue;
            btnTìm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnTìm.Location = new System.Drawing.Point(1471, 151);
            btnTìm.Name = "btnTìm";
            btnTìm.Size = new System.Drawing.Size(59, 41);
            btnTìm.TabIndex = 14;
            btnTìm.Text = "Tìm";
            btnTìm.UseVisualStyleBackColor = false;
            btnTìm.Click += btnXemChiTiet_Click;
            // 
            // LichSuBanThuoc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtTimKiemHoaDon);
            Controls.Add(btnTìm);
            Controls.Add(btnXemChiTiet);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgvSalesHistory);
            Name = "LichSuBanThuoc";
            Size = new System.Drawing.Size(1673, 870);
            Load += LichSuBanThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesHistory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.Label lblPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemChiTiet;
        public System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.Button btnTìm;
    }
}
