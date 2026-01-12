namespace DashBoarV2.USER
{
    partial class viewmedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewmedicine));
            panel1 = new System.Windows.Forms.Panel();
            lblDanhSachThuoc = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbltenthuoc = new System.Windows.Forms.Label();
            TxtSearch = new System.Windows.Forms.TextBox();
            dgvViewthuoc = new System.Windows.Forms.DataGridView();
            btnXoa = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvViewthuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDanhSachThuoc);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(61, 33);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(396, 101);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblDanhSachThuoc
            // 
            lblDanhSachThuoc.AutoSize = true;
            lblDanhSachThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblDanhSachThuoc.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDanhSachThuoc.Location = new System.Drawing.Point(134, 28);
            lblDanhSachThuoc.Name = "lblDanhSachThuoc";
            lblDanhSachThuoc.Size = new System.Drawing.Size(199, 41);
            lblDanhSachThuoc.TabIndex = 4;
            lblDanhSachThuoc.Text = "Kho Thuốc";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.price_list;
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(107, 95);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbltenthuoc
            // 
            lbltenthuoc.AutoSize = true;
            lbltenthuoc.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbltenthuoc.Location = new System.Drawing.Point(1134, 88);
            lbltenthuoc.Name = "lbltenthuoc";
            lbltenthuoc.Size = new System.Drawing.Size(160, 34);
            lbltenthuoc.TabIndex = 3;
            lbltenthuoc.Text = "Tên Thuốc";
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            TxtSearch.Location = new System.Drawing.Point(1134, 125);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search.......";
            TxtSearch.Size = new System.Drawing.Size(444, 39);
            TxtSearch.TabIndex = 4;
            TxtSearch.UseWaitCursor = true;
            // 
            // dgvViewthuoc
            // 
            dgvViewthuoc.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dgvViewthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewthuoc.Location = new System.Drawing.Point(102, 199);
            dgvViewthuoc.Name = "dgvViewthuoc";
            dgvViewthuoc.RowHeadersWidth = 51;
            dgvViewthuoc.Size = new System.Drawing.Size(1476, 570);
            dgvViewthuoc.TabIndex = 5;
            // 
            // btnXoa
            // 
            btnXoa.Appearance.BackColor = System.Drawing.Color.IndianRed;
            btnXoa.Appearance.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnXoa.Appearance.ForeColor = System.Drawing.Color.Black;
            btnXoa.Appearance.Options.UseBackColor = true;
            btnXoa.Appearance.Options.UseFont = true;
            btnXoa.Appearance.Options.UseForeColor = true;
            btnXoa.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnXoa.ImageOptions.Image");
            btnXoa.Location = new System.Drawing.Point(1431, 790);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(147, 45);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            btnEdit.Appearance.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEdit.Appearance.ForeColor = System.Drawing.Color.Black;
            btnEdit.Appearance.Options.UseBackColor = true;
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.Appearance.Options.UseForeColor = true;
            btnEdit.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnEdit.ImageOptions.Image");
            btnEdit.Location = new System.Drawing.Point(1251, 790);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(147, 45);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.research;
            pictureBox2.Location = new System.Drawing.Point(1049, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(70, 61);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // viewmedicine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            Controls.Add(pictureBox2);
            Controls.Add(btnEdit);
            Controls.Add(btnXoa);
            Controls.Add(dgvViewthuoc);
            Controls.Add(TxtSearch);
            Controls.Add(lbltenthuoc);
            Controls.Add(panel1);
            Name = "viewmedicine";
            Size = new System.Drawing.Size(1673, 870);
            Load += viewmedicine_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvViewthuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDanhSachThuoc;
        private System.Windows.Forms.Label lbltenthuoc;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView dgvViewthuoc;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
