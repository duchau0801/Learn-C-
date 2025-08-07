namespace DashBoarV2.USER
{
    partial class MedicineNote
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lblSign = new System.Windows.Forms.Label();
            lblinfo = new System.Windows.Forms.Label();
            dgvThuocHetHan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThuocHetHan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20250801_1315_Robot_Công_Nghệ_Hiện_Đại_remix_01k1j46wt9fp5v36b4rzkmy0kz_removebg_preview;
            pictureBox1.Location = new System.Drawing.Point(30, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(535, 609);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.thought_bubble;
            pictureBox2.Location = new System.Drawing.Point(312, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(696, 393);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSign.ForeColor = System.Drawing.Color.Brown;
            lblSign.Location = new System.Drawing.Point(517, 67);
            lblSign.Name = "lblSign";
            lblSign.Size = new System.Drawing.Size(302, 41);
            lblSign.TabIndex = 6;
            lblSign.Text = "[🔔 CẢNH BÁO]: ";
            lblSign.Click += lblSign_Click;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblinfo.ForeColor = System.Drawing.Color.Brown;
            lblinfo.Location = new System.Drawing.Point(543, 134);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new System.Drawing.Size(69, 34);
            lblinfo.TabIndex = 7;
            lblinfo.Text = "info";
            // 
            // dgvThuocHetHan
            // 
            dgvThuocHetHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuocHetHan.Location = new System.Drawing.Point(740, 346);
            dgvThuocHetHan.Name = "dgvThuocHetHan";
            dgvThuocHetHan.RowHeadersWidth = 51;
            dgvThuocHetHan.Size = new System.Drawing.Size(790, 432);
            dgvThuocHetHan.TabIndex = 8;
            // 
            // MedicineNote
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvThuocHetHan);
            Controls.Add(lblinfo);
            Controls.Add(lblSign);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MedicineNote";
            Size = new System.Drawing.Size(1673, 870);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThuocHetHan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.DataGridView dgvThuocHetHan;
    }
}
