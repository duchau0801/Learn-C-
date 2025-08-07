using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab03
{
    public partial class frmQuanLySinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemSV f = new frmThemSV(); // Tạo đối tượng form
            f.ShowDialog(); // Hiển thị form chặn form
        }
        public class SinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string Khoa { get; set; }
            public double DiemTB { get; set; }
        }

    }
}
