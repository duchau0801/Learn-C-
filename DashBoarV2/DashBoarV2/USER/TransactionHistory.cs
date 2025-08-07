using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoarV2.USER
{
    public partial class TransactionHistory : UserControl
    {
        private string connectionString = "Server=DESKTOP-QEUV6JR;Database=QuanLiNhaThuoc;Integrated Security=True;";
        public TransactionHistory()
        {
            InitializeComponent();
            LoadTransactionData();
            SetupAutoCompleteForSearch();
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            dgvGiaodich.SelectionChanged += dgvGiaodich_SelectionChanged;
            btnDetail.Click += btnDetail_Click;
            btnDetail.Enabled = false;
        }

        private void LoadTransactionData(string search = "")
        {
            string query = @"
                SELECT pn.MaPhieuNhap, pn.NgayNhap, ctpn.SoLuongNhap, t.TenThuoc, ncc.TenNCC
                FROM PhieuNhap pn
                JOIN ChiTietPhieuNhap ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap
                JOIN Thuoc t ON ctpn.MaThuoc = t.MaThuoc
                JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
            ";
            if (!string.IsNullOrEmpty(search))
            {
                query += " WHERE pn.MaPhieuNhap LIKE @search";
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(search))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                    }
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvGiaodich.DataSource = dt;
                    dgvGiaodich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu giao dịch: " + ex.Message);
                }
            }
        }

        private void SetupAutoCompleteForSearch()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT MaPhieuNhap FROM PhieuNhap";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        collection.Add(reader["MaPhieuNhap"].ToString());
                    }
                    reader.Close();
                    TxtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    TxtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    TxtSearch.AutoCompleteCustomSource = collection;
                }
                catch (Exception ex)
                {
                    // Không cần báo lỗi khi autocomplete
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = TxtSearch.Text.Trim();
            LoadTransactionData(searchText);
        }

        private void dgvGiaodich_SelectionChanged(object sender, EventArgs e)
        {
            btnDetail.Enabled = dgvGiaodich.SelectedRows.Count > 0;
            btnDetail.BackColor = btnDetail.Enabled ? Color.MediumAquamarine : Color.LightGray;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvGiaodich.SelectedRows.Count > 0)
            {
                var row = dgvGiaodich.SelectedRows[0];
                string maPhieuNhap = row.Cells["MaPhieuNhap"].Value?.ToString();
                string ngayNhap = row.Cells["NgayNhap"].Value?.ToString();
                string soLuongNhap = row.Cells["SoLuongNhap"].Value?.ToString();
                string tenThuoc = row.Cells["TenThuoc"].Value?.ToString();
                string tenNCC = row.Cells["TenNCC"].Value?.ToString();

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    var pnlmain = parentForm.Controls.Find("pnlmain", true).FirstOrDefault();
                    if (pnlmain != null)
                    {
                        pnlmain.Controls.Clear();
                        var addMed = new addmedicine();
                        addMed.Dock = DockStyle.Fill;
                        pnlmain.Controls.Add(addMed);

                        // Lấy thêm thông tin thuốc từ DB
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = @"
                                SELECT t.MaThuoc, t.TenThuoc, t.LoaiThuoc, t.DonViTinh, t.GiaMua, t.GiaBan, t.SoLuongTon, ctpn.HanSuDung, pn.NgayNhap, ncc.TenNCC
                                FROM PhieuNhap pn
                                JOIN ChiTietPhieuNhap ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap
                                JOIN Thuoc t ON ctpn.MaThuoc = t.MaThuoc
                                JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
                                WHERE pn.MaPhieuNhap = @MaPhieuNhap";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                addMed.TxtMaThuoc.Text = reader["MaThuoc"].ToString();
                                addMed.TxtTenThuoc.Text = reader["TenThuoc"].ToString();
                                addMed.cmbLoaiThuoc.Text = reader["LoaiThuoc"].ToString();
                                addMed.cmbDonViThuoc.Text = reader["DonViTinh"].ToString();
                                addMed.TxtGiaVon.Text = reader["GiaMua"].ToString();
                                addMed.TxtGiaBan.Text = reader["GiaBan"].ToString();
                                addMed.TxtSoluong.Text = reader["SoLuongTon"].ToString();
                                if (DateTime.TryParse(reader["HanSuDung"].ToString(), out DateTime hsd))
                                    addMed.dateTimePicker1.Value = hsd;
                                if (reader["NgayNhap"] != DBNull.Value && DateTime.TryParse(reader["NgayNhap"].ToString(), out DateTime ngayNhapDt))
                                    addMed.dateNSX.Value = ngayNhapDt;
                                addMed.textBox1.Text = reader["TenNCC"].ToString();
                            }
                            reader.Close();
                        }
                        addMed.ShowUpdateMode();
                    }
                }
            }
        }
    }
}
