using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DashBoarV2.USER
{
    public partial class LichSuBanThuoc : UserControl
    {
        private string invoiceFolder = @"D:\HoaDon";
        private DataTable invoiceTable = new DataTable();

        public LichSuBanThuoc()
        {
            InitializeComponent();
            this.Load += LichSuBanThuoc_Load;
            btnTìm.Click += btnTim_Click;
        }

        private void LichSuBanThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSalesHistory.AutoGenerateColumns = true;
                dgvSalesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Định nghĩa các cột
                invoiceTable.Columns.Clear();
                invoiceTable.Columns.Add("Tên File");
                invoiceTable.Columns.Add("Ngày", typeof(DateTime));
                invoiceTable.Columns.Add("Đường Dẫn");

                dgvSalesHistory.DataSource = invoiceTable;

                // Tải dữ liệu
                LoadInvoices();

                // Format cột ngày hiển thị
                dgvSalesHistory.Columns["Ngày"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvSalesHistory.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void LoadInvoices()
        {
            try
            {
                invoiceTable.Rows.Clear();
                if (!Directory.Exists(invoiceFolder)) return;

                var files = Directory.GetFiles(invoiceFolder, "*.pdf");

                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    DateTime date = File.GetCreationTime(file).Date; // chỉ lấy ngày
                    invoiceTable.Rows.Add(fileName, date, file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load hóa đơn: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string input = txtTimKiemHoaDon.Text.Trim();

            // Không nhập gì thì hiển thị toàn bộ
            if (string.IsNullOrEmpty(input))
            {
                dgvSalesHistory.DataSource = invoiceTable;
                return;
            }

            // Nhập ngày, kiểm tra định dạng
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime selectedDate))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày (dd/MM/yyyy).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc theo ngày
            var filteredRows = invoiceTable.AsEnumerable()
                .Where(row => ((DateTime)row["Ngày"]).Date == selectedDate.Date);

            if (filteredRows.Any())
            {
                dgvSalesHistory.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                MessageBox.Show("Không có ngày này trong Cơ sở Dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSalesHistory.DataSource = null;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvSalesHistory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSalesHistory.SelectedRows[0];

                // Kiểm tra nếu dòng được chọn là hợp lệ và có giá trị đường dẫn
                if (selectedRow.Cells["Đường Dẫn"].Value != null)
                {
                    string filePath = selectedRow.Cells["Đường Dẫn"].Value.ToString();

                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                        return;
                    }
                }

                // Nếu đường dẫn không hợp lệ hoặc không tồn tại
                MessageBox.Show("Không tìm thấy file hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Chỉ hiển thị khi chưa chọn hàng nào
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvSalesHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tuỳ chọn: xử lý sự kiện khi click vào cell
        }
    }
}