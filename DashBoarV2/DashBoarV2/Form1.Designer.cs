namespace DashBoarV2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageSidebar = new System.Windows.Forms.ImageList(components);
            Timer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            pnIn4 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pnlDashBoard = new System.Windows.Forms.Panel();
            btnDashBoard = new System.Windows.Forms.Button();
            pnlMedicine = new System.Windows.Forms.Panel();
            panelSubMenuMedicine = new System.Windows.Forms.Panel();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            btnPhieuNhap = new System.Windows.Forms.Button();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            btnViewmedicine = new System.Windows.Forms.Button();
            btnAddmedicine = new System.Windows.Forms.Button();
            btnMedicine = new System.Windows.Forms.Button();
            pnlSale = new System.Windows.Forms.Panel();
            panelSubMenuSale = new System.Windows.Forms.Panel();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            btnLichSuMuaHang = new System.Windows.Forms.Button();
            pictureBox9 = new System.Windows.Forms.PictureBox();
            btnSellMedicine = new System.Windows.Forms.Button();
            btnSale = new System.Windows.Forms.Button();
            pnlAccount = new System.Windows.Forms.Panel();
            btnAccount = new System.Windows.Forms.Button();
            pnlCustomer = new System.Windows.Forms.Panel();
            btnCustomer = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            pnlLogOut = new System.Windows.Forms.Panel();
            btnLogOut = new System.Windows.Forms.Button();
            pnHeader = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lblTime = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            pnlmain = new System.Windows.Forms.Panel();
            flowLayoutPanel1.SuspendLayout();
            pnIn4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDashBoard.SuspendLayout();
            pnlMedicine.SuspendLayout();
            panelSubMenuMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlSale.SuspendLayout();
            panelSubMenuSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnlAccount.SuspendLayout();
            pnlCustomer.SuspendLayout();
            pnlLogOut.SuspendLayout();
            pnHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageSidebar
            // 
            imageSidebar.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageSidebar.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageSidebar.ImageStream");
            imageSidebar.TransparentColor = System.Drawing.Color.Transparent;
            imageSidebar.Images.SetKeyName(0, "icons8-dashboard-100 (1).png");
            imageSidebar.Images.SetKeyName(1, "icons8-medicine-100.png");
            imageSidebar.Images.SetKeyName(2, "icons8-shopping-cart-50.png");
            imageSidebar.Images.SetKeyName(3, "icons8-account-100.png");
            imageSidebar.Images.SetKeyName(4, "icons8-group-100.png");
            imageSidebar.Images.SetKeyName(5, "icons8-exit-100.png");
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            flowLayoutPanel1.Controls.Add(pnIn4);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(pnlDashBoard);
            flowLayoutPanel1.Controls.Add(pnlMedicine);
            flowLayoutPanel1.Controls.Add(pnlSale);
            flowLayoutPanel1.Controls.Add(pnlAccount);
            flowLayoutPanel1.Controls.Add(pnlCustomer);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(pnlLogOut);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(250, 995);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pnIn4
            // 
            pnIn4.BackColor = System.Drawing.Color.White;
            pnIn4.Controls.Add(pictureBox1);
            pnIn4.Controls.Add(label2);
            pnIn4.Controls.Add(label1);
            pnIn4.Location = new System.Drawing.Point(3, 3);
            pnIn4.Name = "pnIn4";
            pnIn4.Size = new System.Drawing.Size(241, 102);
            pnIn4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(94, 73);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(107, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 23);
            label2.TabIndex = 2;
            label2.Text = "MA_02345";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(108, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 23);
            label1.TabIndex = 1;
            label1.Text = "MaiTruong";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(3, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(247, 25);
            label3.TabIndex = 16;
            label3.Text = "___________________________________________";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDashBoard
            // 
            pnlDashBoard.Controls.Add(btnDashBoard);
            pnlDashBoard.Location = new System.Drawing.Point(3, 143);
            pnlDashBoard.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new System.Drawing.Size(247, 60);
            pnlDashBoard.TabIndex = 17;
            // 
            // btnDashBoard
            // 
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = System.Drawing.Color.White;
            btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashBoard.ImageIndex = 0;
            btnDashBoard.Location = new System.Drawing.Point(56, 3);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new System.Drawing.Size(156, 54);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "     DashBoard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // pnlMedicine
            // 
            pnlMedicine.AutoSize = true;
            pnlMedicine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnlMedicine.Controls.Add(panelSubMenuMedicine);
            pnlMedicine.Controls.Add(btnMedicine);
            pnlMedicine.Location = new System.Drawing.Point(3, 223);
            pnlMedicine.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            pnlMedicine.Name = "pnlMedicine";
            pnlMedicine.Size = new System.Drawing.Size(249, 218);
            pnlMedicine.TabIndex = 18;
            pnlMedicine.Paint += pnlMedicine_Paint;
            // 
            // panelSubMenuMedicine
            // 
            panelSubMenuMedicine.BackColor = System.Drawing.SystemColors.HotTrack;
            panelSubMenuMedicine.Controls.Add(pictureBox6);
            panelSubMenuMedicine.Controls.Add(btnPhieuNhap);
            panelSubMenuMedicine.Controls.Add(pictureBox5);
            panelSubMenuMedicine.Controls.Add(pictureBox4);
            panelSubMenuMedicine.Controls.Add(btnViewmedicine);
            panelSubMenuMedicine.Controls.Add(btnAddmedicine);
            panelSubMenuMedicine.Location = new System.Drawing.Point(53, 50);
            panelSubMenuMedicine.Name = "panelSubMenuMedicine";
            panelSubMenuMedicine.Size = new System.Drawing.Size(193, 165);
            panelSubMenuMedicine.TabIndex = 8;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.DodgerBlue;
            pictureBox6.Image = Properties.Resources.package_receipt;
            pictureBox6.Location = new System.Drawing.Point(3, 107);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(44, 46);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = System.Drawing.Color.DodgerBlue;
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPhieuNhap.ForeColor = System.Drawing.Color.White;
            btnPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPhieuNhap.ImageIndex = 1;
            btnPhieuNhap.Location = new System.Drawing.Point(5, 107);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Size = new System.Drawing.Size(185, 46);
            btnPhieuNhap.TabIndex = 7;
            btnPhieuNhap.Text = "        Transaction history";
            btnPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.DodgerBlue;
            pictureBox5.Image = Properties.Resources.price_list;
            pictureBox5.Location = new System.Drawing.Point(5, 58);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(46, 43);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.DodgerBlue;
            pictureBox4.Image = Properties.Resources.add__1_;
            pictureBox4.Location = new System.Drawing.Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(46, 46);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btnViewmedicine
            // 
            btnViewmedicine.BackColor = System.Drawing.Color.DodgerBlue;
            btnViewmedicine.FlatAppearance.BorderSize = 0;
            btnViewmedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewmedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnViewmedicine.ForeColor = System.Drawing.Color.White;
            btnViewmedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnViewmedicine.ImageIndex = 1;
            btnViewmedicine.Location = new System.Drawing.Point(3, 55);
            btnViewmedicine.Name = "btnViewmedicine";
            btnViewmedicine.Size = new System.Drawing.Size(185, 46);
            btnViewmedicine.TabIndex = 3;
            btnViewmedicine.Text = "View Medicine";
            btnViewmedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnViewmedicine.UseVisualStyleBackColor = false;
            btnViewmedicine.Click += button2_Click_1;
            // 
            // btnAddmedicine
            // 
            btnAddmedicine.BackColor = System.Drawing.Color.DodgerBlue;
            btnAddmedicine.FlatAppearance.BorderSize = 0;
            btnAddmedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddmedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddmedicine.ForeColor = System.Drawing.Color.White;
            btnAddmedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddmedicine.ImageIndex = 1;
            btnAddmedicine.Location = new System.Drawing.Point(5, 3);
            btnAddmedicine.Name = "btnAddmedicine";
            btnAddmedicine.Size = new System.Drawing.Size(186, 46);
            btnAddmedicine.TabIndex = 2;
            btnAddmedicine.Text = "Add Medicine";
            btnAddmedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddmedicine.UseVisualStyleBackColor = false;
            btnAddmedicine.Click += btnAddmedicine_Click;
            // 
            // btnMedicine
            // 
            btnMedicine.FlatAppearance.BorderSize = 0;
            btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMedicine.ForeColor = System.Drawing.Color.White;
            btnMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMedicine.ImageIndex = 1;
            btnMedicine.Location = new System.Drawing.Point(56, 3);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new System.Drawing.Size(156, 54);
            btnMedicine.TabIndex = 1;
            btnMedicine.Text = "    Medicine";
            btnMedicine.UseVisualStyleBackColor = true;
            btnMedicine.Click += btnMedicine_Click_1;
            // 
            // pnlSale
            // 
            pnlSale.Controls.Add(panelSubMenuSale);
            pnlSale.Controls.Add(btnSale);
            pnlSale.Location = new System.Drawing.Point(3, 461);
            pnlSale.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            pnlSale.Name = "pnlSale";
            pnlSale.Size = new System.Drawing.Size(247, 159);
            pnlSale.TabIndex = 19;
            // 
            // panelSubMenuSale
            // 
            panelSubMenuSale.BackColor = System.Drawing.SystemColors.HotTrack;
            panelSubMenuSale.Controls.Add(pictureBox7);
            panelSubMenuSale.Controls.Add(btnLichSuMuaHang);
            panelSubMenuSale.Controls.Add(pictureBox9);
            panelSubMenuSale.Controls.Add(btnSellMedicine);
            panelSubMenuSale.Location = new System.Drawing.Point(53, 49);
            panelSubMenuSale.Name = "panelSubMenuSale";
            panelSubMenuSale.Size = new System.Drawing.Size(196, 107);
            panelSubMenuSale.TabIndex = 9;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = System.Drawing.Color.DodgerBlue;
            pictureBox7.Image = Properties.Resources.package_receipt;
            pictureBox7.Location = new System.Drawing.Point(6, 55);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(44, 46);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // btnLichSuMuaHang
            // 
            btnLichSuMuaHang.BackColor = System.Drawing.Color.DodgerBlue;
            btnLichSuMuaHang.FlatAppearance.BorderSize = 0;
            btnLichSuMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLichSuMuaHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLichSuMuaHang.ForeColor = System.Drawing.Color.White;
            btnLichSuMuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLichSuMuaHang.ImageIndex = 1;
            btnLichSuMuaHang.Location = new System.Drawing.Point(9, 55);
            btnLichSuMuaHang.Name = "btnLichSuMuaHang";
            btnLichSuMuaHang.Size = new System.Drawing.Size(189, 46);
            btnLichSuMuaHang.TabIndex = 7;
            btnLichSuMuaHang.Text = "Lịch Sử Bán Thuốc";
            btnLichSuMuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLichSuMuaHang.UseVisualStyleBackColor = false;
            btnLichSuMuaHang.Click += btnLichSuMuaHang_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = System.Drawing.Color.DodgerBlue;
            pictureBox9.Image = Properties.Resources.add__1_;
            pictureBox9.Location = new System.Drawing.Point(3, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(46, 46);
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // btnSellMedicine
            // 
            btnSellMedicine.BackColor = System.Drawing.Color.DodgerBlue;
            btnSellMedicine.FlatAppearance.BorderSize = 0;
            btnSellMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSellMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSellMedicine.ForeColor = System.Drawing.Color.White;
            btnSellMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSellMedicine.ImageIndex = 1;
            btnSellMedicine.Location = new System.Drawing.Point(5, 3);
            btnSellMedicine.Name = "btnSellMedicine";
            btnSellMedicine.Size = new System.Drawing.Size(193, 46);
            btnSellMedicine.TabIndex = 2;
            btnSellMedicine.Text = "Sell Medicine";
            btnSellMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSellMedicine.UseVisualStyleBackColor = false;
            btnSellMedicine.Click += btnSellMedicine_Click;
            // 
            // btnSale
            // 
            btnSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSale.ForeColor = System.Drawing.Color.White;
            btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSale.ImageIndex = 2;
            btnSale.Location = new System.Drawing.Point(56, 9);
            btnSale.Name = "btnSale";
            btnSale.Size = new System.Drawing.Size(156, 54);
            btnSale.TabIndex = 2;
            btnSale.Text = "Sales";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click_1;
            // 
            // pnlAccount
            // 
            pnlAccount.Controls.Add(btnAccount);
            pnlAccount.Location = new System.Drawing.Point(3, 640);
            pnlAccount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new System.Drawing.Size(246, 69);
            pnlAccount.TabIndex = 20;
            // 
            // btnAccount
            // 
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAccount.ForeColor = System.Drawing.Color.White;
            btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAccount.ImageIndex = 3;
            btnAccount.Location = new System.Drawing.Point(56, 12);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new System.Drawing.Size(156, 54);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "      Accounts";
            btnAccount.UseVisualStyleBackColor = true;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(btnCustomer);
            pnlCustomer.Location = new System.Drawing.Point(3, 729);
            pnlCustomer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new System.Drawing.Size(247, 70);
            pnlCustomer.TabIndex = 21;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = System.Drawing.Color.White;
            btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCustomer.ImageIndex = 4;
            btnCustomer.Location = new System.Drawing.Point(56, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new System.Drawing.Size(156, 54);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "      Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(3, 809);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(247, 25);
            label4.TabIndex = 22;
            label4.Text = "___________________________________________";
            // 
            // pnlLogOut
            // 
            pnlLogOut.Controls.Add(btnLogOut);
            pnlLogOut.Location = new System.Drawing.Point(3, 844);
            pnlLogOut.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            pnlLogOut.Name = "pnlLogOut";
            pnlLogOut.Size = new System.Drawing.Size(247, 69);
            pnlLogOut.TabIndex = 23;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = System.Drawing.Color.White;
            btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogOut.ImageIndex = 5;
            btnLogOut.Location = new System.Drawing.Point(56, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(156, 54);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "  LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = System.Drawing.Color.White;
            pnHeader.Controls.Add(button1);
            pnHeader.Controls.Add(txtSearch);
            pnHeader.Controls.Add(panel1);
            pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnHeader.Location = new System.Drawing.Point(250, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new System.Drawing.Size(1673, 129);
            pnHeader.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(411, 34);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(63, 50);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.AliceBlue;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.Location = new System.Drawing.Point(74, 41);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for...";
            txtSearch.Size = new System.Drawing.Size(321, 41);
            txtSearch.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDate);
            panel1.Location = new System.Drawing.Point(1100, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(540, 90);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(338, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(57, 51);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(13, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(57, 51);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblTime.Location = new System.Drawing.Point(422, 26);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(110, 39);
            lblTime.TabIndex = 1;
            lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDate.Location = new System.Drawing.Point(92, 26);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(218, 41);
            lblDate.TabIndex = 0;
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlmain
            // 
            pnlmain.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlmain.Location = new System.Drawing.Point(250, 125);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new System.Drawing.Size(1673, 870);
            pnlmain.TabIndex = 9;
            // 
            // Form1
            // 
            Appearance.BackColor = System.Drawing.Color.AliceBlue;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1923, 995);
            Controls.Add(pnlmain);
            Controls.Add(pnHeader);
            Controls.Add(flowLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Form1";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnIn4.ResumeLayout(false);
            pnIn4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDashBoard.ResumeLayout(false);
            pnlMedicine.ResumeLayout(false);
            panelSubMenuMedicine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlSale.ResumeLayout(false);
            panelSubMenuSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnlAccount.ResumeLayout(false);
            pnlCustomer.ResumeLayout(false);
            pnlLogOut.ResumeLayout(false);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageSidebar;
        private System.Windows.Forms.Timer Timer;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnIn4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel pnlMedicine;
        private System.Windows.Forms.Panel panelSubMenuMedicine;
        private System.Windows.Forms.Button btnViewmedicine;
        private System.Windows.Forms.Button btnAddmedicine;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Panel pnlSale;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panelSubMenuSale;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnLichSuMuaHang;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnSellMedicine;
    }
}

