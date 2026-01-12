using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab03.frmQuanLySinhVien;

namespace Lab03
{
    public partial class frmThemSV : Form
    {
        public frmThemSV()
        {
            InitializeComponent();
        }
        private List<SinhVien> danhSachSinhVien;
        private DataGridView dgvSinhVien;
        public SinhVien SinhVienMoi { get; private set; }

        public void SetData(List<SinhVien> danhSachSV, DataGridView dgv)
        {
            danhSachSinhVien = danhSachSV;
            dgvSinhVien = dgv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu nhập vào (Validation)
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text) || cboKhoa.SelectedItem == null || string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu thiếu thông tin
            }

            if (!double.TryParse(txtDiemTB.Text, out double diem))
            {
                MessageBox.Show("Điểm trung bình phải là một số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu điểm không hợp lệ
            }

            // 2. Tạo đối tượng sinh viên mới từ dữ liệu trên form
            SinhVienMoi = new SinhVien
            {
                MaSV = txtMaSV.Text,
                TenSV = txtTenSV.Text,
                Khoa = cboKhoa.SelectedItem.ToString(),
                DiemTB = diem
            };

            // 3. Đặt DialogResult là OK để báo cho form chính biết việc thêm đã thành công
            this.DialogResult = DialogResult.OK;
        }
    }
}
