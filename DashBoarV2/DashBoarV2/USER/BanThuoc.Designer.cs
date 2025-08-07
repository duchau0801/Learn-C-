namespace DashBoarV2.USER
{
    partial class BanThuoc
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanThuoc));
            groudboxThongTin = new System.Windows.Forms.GroupBox();
            lstSuggestions = new System.Windows.Forms.ListView();
            lblTimKiem = new System.Windows.Forms.Label();
            txtTimKiemThuoc = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            lblDanhSachThuoc = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dgvThongTinHoaDon = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnThanhToan = new System.Windows.Forms.Button();
            imageList3 = new System.Windows.Forms.ImageList(components);
            txtTongTienHoaDon = new System.Windows.Forms.TextBox();
            imageList2 = new System.Windows.Forms.ImageList(components);
            imageList1 = new System.Windows.Forms.ImageList(components);
            txtTenThuoc = new System.Windows.Forms.TextBox();
            txtTenNV = new System.Windows.Forms.TextBox();
            txtTongGia = new System.Windows.Forms.TextBox();
            txtMaThuoc = new System.Windows.Forms.TextBox();
            lblMaThuoc = new System.Windows.Forms.Label();
            lblDonViThuoc = new System.Windows.Forms.Label();
            lblLoaiThuoc = new System.Windows.Forms.Label();
            lblTenThuoc = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblSoluong = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtSoLuong = new System.Windows.Forms.TextBox();
            txtTenKH = new System.Windows.Forms.TextBox();
            txtDonViTinh = new System.Windows.Forms.TextBox();
            btnThemSuaHoaDon = new System.Windows.Forms.Button();
            btnXoaHoaDon = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pnlBanDonThuoc = new System.Windows.Forms.Panel();
            cbBanTheoDon = new System.Windows.Forms.CheckBox();
            txtTenDonThuoc = new System.Windows.Forms.TextBox();
            cbBanLe = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            txtDonGia = new System.Windows.Forms.TextBox();
            groudboxThongTin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinHoaDon).BeginInit();
            groupBox1.SuspendLayout();
            pnlBanDonThuoc.SuspendLayout();
            SuspendLayout();
            // 
            // groudboxThongTin
            // 
            groudboxThongTin.BackColor = System.Drawing.Color.LightSteelBlue;
            groudboxThongTin.Controls.Add(lstSuggestions);
            groudboxThongTin.Controls.Add(lblTimKiem);
            groudboxThongTin.Controls.Add(txtTimKiemThuoc);
            groudboxThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groudboxThongTin.Location = new System.Drawing.Point(32, 94);
            groudboxThongTin.Name = "groudboxThongTin";
            groudboxThongTin.Size = new System.Drawing.Size(415, 715);
            groudboxThongTin.TabIndex = 15;
            groudboxThongTin.TabStop = false;
            groudboxThongTin.Text = "Tìm Kiếm";
            // 
            // lstSuggestions
            // 
            lstSuggestions.Location = new System.Drawing.Point(7, 68);
            lstSuggestions.Name = "lstSuggestions";
            lstSuggestions.Size = new System.Drawing.Size(400, 641);
            lstSuggestions.TabIndex = 4;
            lstSuggestions.UseCompatibleStateImageBehavior = false;
            lstSuggestions.SelectedIndexChanged += lstSuggestions_SelectedIndexChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.BackColor = System.Drawing.Color.Snow;
            lblTimKiem.Location = new System.Drawing.Point(7, 37);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(151, 28);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm Kiếm Thuốc";
            // 
            // txtTimKiemThuoc
            // 
            txtTimKiemThuoc.Location = new System.Drawing.Point(180, 37);
            txtTimKiemThuoc.Multiline = true;
            txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            txtTimKiemThuoc.Size = new System.Drawing.Size(227, 28);
            txtTimKiemThuoc.TabIndex = 3;
            txtTimKiemThuoc.TextChanged += txtTimKiemThuoc_TextChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDanhSachThuoc);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(422, 79);
            panel1.TabIndex = 14;
            // 
            // lblDanhSachThuoc
            // 
            lblDanhSachThuoc.AutoSize = true;
            lblDanhSachThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblDanhSachThuoc.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDanhSachThuoc.Location = new System.Drawing.Point(145, 21);
            lblDanhSachThuoc.Name = "lblDanhSachThuoc";
            lblDanhSachThuoc.Size = new System.Drawing.Size(197, 41);
            lblDanhSachThuoc.TabIndex = 5;
            lblDanhSachThuoc.Text = "Bán Thuốc";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new System.Drawing.Point(15, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(92, 68);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dgvThongTinHoaDon
            // 
            dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column4, Column3, Column5, Column6, Column7 });
            dgvThongTinHoaDon.Location = new System.Drawing.Point(453, 420);
            dgvThongTinHoaDon.Name = "dgvThongTinHoaDon";
            dgvThongTinHoaDon.RowHeadersWidth = 51;
            dgvThongTinHoaDon.Size = new System.Drawing.Size(1150, 389);
            dgvThongTinHoaDon.TabIndex = 19;
            dgvThongTinHoaDon.SelectionChanged += dgvThongTinHoaDon_SelectionChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Mã Thuốc";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Tên Thuốc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Đơn Vị Tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Số Lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Tổng Giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tên Khách Hàng";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tên Nhân Viên";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btnThanhToan
            // 
            btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnThanhToan.ImageKey = "bill.png";
            btnThanhToan.ImageList = imageList3;
            btnThanhToan.Location = new System.Drawing.Point(1361, 815);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new System.Drawing.Size(211, 44);
            btnThanhToan.TabIndex = 17;
            btnThanhToan.Text = "Thanh toán và In hóa đơn";
            btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList3.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = System.Drawing.Color.Transparent;
            imageList3.Images.SetKeyName(0, "bill.png");
            // 
            // txtTongTienHoaDon
            // 
            txtTongTienHoaDon.Location = new System.Drawing.Point(1171, 817);
            txtTongTienHoaDon.Multiline = true;
            txtTongTienHoaDon.Name = "txtTongTienHoaDon";
            txtTongTienHoaDon.ReadOnly = true;
            txtTongTienHoaDon.Size = new System.Drawing.Size(184, 42);
            txtTongTienHoaDon.TabIndex = 16;
            txtTongTienHoaDon.Text = "Tổng giá tiền:";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "delete.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "shopping-cart.png");
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new System.Drawing.Point(226, 83);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.ReadOnly = true;
            txtTenThuoc.Size = new System.Drawing.Size(262, 34);
            txtTenThuoc.TabIndex = 6;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new System.Drawing.Point(831, 76);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new System.Drawing.Size(262, 34);
            txtTenNV.TabIndex = 6;
            // 
            // txtTongGia
            // 
            txtTongGia.Location = new System.Drawing.Point(226, 272);
            txtTongGia.Name = "txtTongGia";
            txtTongGia.ReadOnly = true;
            txtTongGia.Size = new System.Drawing.Size(262, 34);
            txtTongGia.TabIndex = 6;
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Location = new System.Drawing.Point(226, 30);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.ReadOnly = true;
            txtMaThuoc.Size = new System.Drawing.Size(262, 34);
            txtMaThuoc.TabIndex = 3;
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.BackColor = System.Drawing.Color.Snow;
            lblMaThuoc.Location = new System.Drawing.Point(10, 36);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new System.Drawing.Size(98, 28);
            lblMaThuoc.TabIndex = 1;
            lblMaThuoc.Text = "Mã Thuốc";
            // 
            // lblDonViThuoc
            // 
            lblDonViThuoc.AutoSize = true;
            lblDonViThuoc.BackColor = System.Drawing.Color.Snow;
            lblDonViThuoc.Location = new System.Drawing.Point(10, 131);
            lblDonViThuoc.Name = "lblDonViThuoc";
            lblDonViThuoc.Size = new System.Drawing.Size(113, 28);
            lblDonViThuoc.TabIndex = 9;
            lblDonViThuoc.Text = "Đơn Vị Tính";
            // 
            // lblLoaiThuoc
            // 
            lblLoaiThuoc.AutoSize = true;
            lblLoaiThuoc.BackColor = System.Drawing.Color.Snow;
            lblLoaiThuoc.Location = new System.Drawing.Point(10, 278);
            lblLoaiThuoc.Name = "lblLoaiThuoc";
            lblLoaiThuoc.Size = new System.Drawing.Size(91, 28);
            lblLoaiThuoc.TabIndex = 7;
            lblLoaiThuoc.Text = "Tổng Giá";
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.BackColor = System.Drawing.Color.Snow;
            lblTenThuoc.Location = new System.Drawing.Point(10, 83);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new System.Drawing.Size(99, 28);
            lblTenThuoc.TabIndex = 5;
            lblTenThuoc.Text = "Tên Thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Snow;
            label2.Location = new System.Drawing.Point(666, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 28);
            label2.TabIndex = 5;
            label2.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Snow;
            label4.Location = new System.Drawing.Point(666, 137);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 28);
            label4.TabIndex = 5;
            // 
            // lblSoluong
            // 
            lblSoluong.AutoSize = true;
            lblSoluong.BackColor = System.Drawing.Color.Snow;
            lblSoluong.Location = new System.Drawing.Point(10, 187);
            lblSoluong.Name = "lblSoluong";
            lblSoluong.Size = new System.Drawing.Size(96, 28);
            lblSoluong.TabIndex = 11;
            lblSoluong.Text = "Số Lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Snow;
            label1.Location = new System.Drawing.Point(666, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 28);
            label1.TabIndex = 11;
            label1.Text = "Tên Khách Hàng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new System.Drawing.Point(227, 184);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new System.Drawing.Size(261, 34);
            txtSoLuong.TabIndex = 12;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new System.Drawing.Point(831, 24);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new System.Drawing.Size(261, 34);
            txtTenKH.TabIndex = 12;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new System.Drawing.Point(226, 131);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.ReadOnly = true;
            txtDonViTinh.Size = new System.Drawing.Size(262, 34);
            txtDonViTinh.TabIndex = 12;
            // 
            // btnThemSuaHoaDon
            // 
            btnThemSuaHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnThemSuaHoaDon.ImageKey = "shopping-cart.png";
            btnThemSuaHoaDon.ImageList = imageList1;
            btnThemSuaHoaDon.Location = new System.Drawing.Point(870, 270);
            btnThemSuaHoaDon.Name = "btnThemSuaHoaDon";
            btnThemSuaHoaDon.Size = new System.Drawing.Size(131, 44);
            btnThemSuaHoaDon.TabIndex = 13;
            btnThemSuaHoaDon.Text = "Thêm/Sửa";
            btnThemSuaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnThemSuaHoaDon.UseVisualStyleBackColor = true;
            btnThemSuaHoaDon.Click += btnThemSuaHoaDon_Click;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnXoaHoaDon.ImageKey = "delete.png";
            btnXoaHoaDon.ImageList = imageList2;
            btnXoaHoaDon.Location = new System.Drawing.Point(1029, 270);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new System.Drawing.Size(101, 44);
            btnXoaHoaDon.TabIndex = 13;
            btnXoaHoaDon.Text = "Xóa";
            btnXoaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            groupBox1.Controls.Add(pnlBanDonThuoc);
            groupBox1.Controls.Add(cbBanLe);
            groupBox1.Controls.Add(btnXoaHoaDon);
            groupBox1.Controls.Add(btnThemSuaHoaDon);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSoluong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTenThuoc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblLoaiThuoc);
            groupBox1.Controls.Add(lblDonViThuoc);
            groupBox1.Controls.Add(lblMaThuoc);
            groupBox1.Controls.Add(txtMaThuoc);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTongGia);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtTenThuoc);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(453, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1150, 320);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // pnlBanDonThuoc
            // 
            pnlBanDonThuoc.Controls.Add(cbBanTheoDon);
            pnlBanDonThuoc.Controls.Add(txtTenDonThuoc);
            pnlBanDonThuoc.Location = new System.Drawing.Point(832, 137);
            pnlBanDonThuoc.Name = "pnlBanDonThuoc";
            pnlBanDonThuoc.Size = new System.Drawing.Size(287, 81);
            pnlBanDonThuoc.TabIndex = 16;
            // 
            // cbBanTheoDon
            // 
            cbBanTheoDon.AutoSize = true;
            cbBanTheoDon.Location = new System.Drawing.Point(3, 3);
            cbBanTheoDon.Name = "cbBanTheoDon";
            cbBanTheoDon.Size = new System.Drawing.Size(166, 32);
            cbBanTheoDon.TabIndex = 15;
            cbBanTheoDon.Text = "Bán Đơn Thuốc";
            cbBanTheoDon.UseVisualStyleBackColor = true;
            cbBanTheoDon.CheckedChanged += cbBanTheoDon_CheckedChanged;
            // 
            // txtTenDonThuoc
            // 
            txtTenDonThuoc.Location = new System.Drawing.Point(3, 41);
            txtTenDonThuoc.Name = "txtTenDonThuoc";
            txtTenDonThuoc.Size = new System.Drawing.Size(271, 34);
            txtTenDonThuoc.TabIndex = 6;
            // 
            // cbBanLe
            // 
            cbBanLe.AutoSize = true;
            cbBanLe.Location = new System.Drawing.Point(666, 137);
            cbBanLe.Name = "cbBanLe";
            cbBanLe.Size = new System.Drawing.Size(90, 32);
            cbBanLe.TabIndex = 14;
            cbBanLe.Text = "Bán Lẻ";
            cbBanLe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Snow;
            label3.Location = new System.Drawing.Point(10, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 28);
            label3.TabIndex = 7;
            label3.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new System.Drawing.Point(227, 229);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new System.Drawing.Size(262, 34);
            txtDonGia.TabIndex = 6;
            // 
            // BanThuoc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvThongTinHoaDon);
            Controls.Add(btnThanhToan);
            Controls.Add(groupBox1);
            Controls.Add(txtTongTienHoaDon);
            Controls.Add(groudboxThongTin);
            Controls.Add(panel1);
            Name = "BanThuoc";
            Size = new System.Drawing.Size(1673, 870);
            groudboxThongTin.ResumeLayout(false);
            groudboxThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinHoaDon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlBanDonThuoc.ResumeLayout(false);
            pnlBanDonThuoc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.GroupBox groudboxThongTin;
        private System.Windows.Forms.ListView lstSuggestions;
        private System.Windows.Forms.Label lblTimKiem;
        public System.Windows.Forms.TextBox txtTimKiemThuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDanhSachThuoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvThongTinHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        public System.Windows.Forms.TextBox txtTongTienHoaDon;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.TextBox txtTenThuoc;
        public System.Windows.Forms.TextBox txtTenNV;
        public System.Windows.Forms.TextBox txtTongGia;
        public System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblMaThuoc;
        private System.Windows.Forms.Label lblDonViThuoc;
        private System.Windows.Forms.Label lblLoaiThuoc;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSoLuong;
        public System.Windows.Forms.TextBox txtTenKH;
        public System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Button btnThemSuaHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBanDonThuoc;
        private System.Windows.Forms.CheckBox cbBanTheoDon;
        private System.Windows.Forms.CheckBox cbBanLe;
        public System.Windows.Forms.TextBox txtTenDonThuoc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
