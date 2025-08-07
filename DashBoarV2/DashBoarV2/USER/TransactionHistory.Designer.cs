namespace DashBoarV2.USER
{
    partial class TransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistory));
            panel1 = new System.Windows.Forms.Panel();
            lblPhieuNhap = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dgvGiaodich = new System.Windows.Forms.DataGridView();
            btnDetail = new DevExpress.XtraEditors.SimpleButton();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            TxtSearch = new System.Windows.Forms.TextBox();
            lblMaGiaoDich = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGiaodich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPhieuNhap);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(34, 28);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(396, 101);
            panel1.TabIndex = 1;
            // 
            // lblPhieuNhap
            // 
            lblPhieuNhap.AutoSize = true;
            lblPhieuNhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblPhieuNhap.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPhieuNhap.Location = new System.Drawing.Point(134, 28);
            lblPhieuNhap.Name = "lblPhieuNhap";
            lblPhieuNhap.Size = new System.Drawing.Size(190, 41);
            lblPhieuNhap.TabIndex = 4;
            lblPhieuNhap.Text = "Giao Dịch ";
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
            // dgvGiaodich
            // 
            dgvGiaodich.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dgvGiaodich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaodich.Location = new System.Drawing.Point(98, 193);
            dgvGiaodich.Name = "dgvGiaodich";
            dgvGiaodich.RowHeadersWidth = 51;
            dgvGiaodich.Size = new System.Drawing.Size(1476, 564);
            dgvGiaodich.TabIndex = 6;
            // 
            // btnDetail
            // 
            btnDetail.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            btnDetail.Appearance.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDetail.Appearance.ForeColor = System.Drawing.Color.Black;
            btnDetail.Appearance.Options.UseBackColor = true;
            btnDetail.Appearance.Options.UseFont = true;
            btnDetail.Appearance.Options.UseForeColor = true;
            btnDetail.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDetail.ImageOptions.Image");
            btnDetail.Location = new System.Drawing.Point(1427, 782);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(147, 45);
            btnDetail.TabIndex = 17;
            btnDetail.Text = "Chi Tiết";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.research;
            pictureBox2.Location = new System.Drawing.Point(1045, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(70, 61);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = System.Drawing.Color.OldLace;
            TxtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            TxtSearch.Location = new System.Drawing.Point(1130, 112);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search.......";
            TxtSearch.Size = new System.Drawing.Size(444, 39);
            TxtSearch.TabIndex = 19;
            TxtSearch.UseWaitCursor = true;
            // 
            // lblMaGiaoDich
            // 
            lblMaGiaoDich.AutoSize = true;
            lblMaGiaoDich.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMaGiaoDich.Location = new System.Drawing.Point(1130, 75);
            lblMaGiaoDich.Name = "lblMaGiaoDich";
            lblMaGiaoDich.Size = new System.Drawing.Size(198, 34);
            lblMaGiaoDich.TabIndex = 18;
            lblMaGiaoDich.Text = "Mã Giao Dịch";
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(TxtSearch);
            Controls.Add(lblMaGiaoDich);
            Controls.Add(btnDetail);
            Controls.Add(dgvGiaodich);
            Controls.Add(panel1);
            Name = "TransactionHistory";
            Size = new System.Drawing.Size(1673, 870);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGiaodich).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPhieuNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvGiaodich;
        private DevExpress.XtraEditors.SimpleButton btnDetail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label lblMaGiaoDich;
    }
}
