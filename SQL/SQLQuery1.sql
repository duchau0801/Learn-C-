CREATE DATABASE QuanLiNhaThuoc;
USE QuanLiNhaThuoc;

-- 1. Bảng người dùng
CREATE TABLE NguoiDung (
    MaNguoiDung VARCHAR(10) PRIMARY KEY,
    TenDangNhap VARCHAR(20) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(50),
    ChucVu NVARCHAR(30),
    Email VARCHAR(50),
    SDT CHAR(11)
);

-- 2. Bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(20) PRIMARY KEY,  
    HoTenKH NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(100),
    SDT CHAR(11),
    Email VARCHAR(50)
);

-- 3. Bảng nhà cung cấp
CREATE TABLE NhaCungCap (
    MaNCC VARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(50),
    DiaChi NVARCHAR(100),
    SDT CHAR(11),
    Email VARCHAR(50)
);

-- 4. Bảng thuốc
CREATE TABLE Thuoc (
    MaThuoc VARCHAR(10) PRIMARY KEY,
    TenThuoc NVARCHAR(50) NOT NULL,
    LoaiThuoc NVARCHAR(30),
    DonViTinh NVARCHAR(20),
    GiaMua DECIMAL(10,2),
    GiaBan DECIMAL(10,2),
    SoLuongTon INT CHECK (SoLuongTon >= 0)
);

-- 5. Bảng hóa đơn
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    MaNguoiDung VARCHAR(10) NOT NULL, 
    MaKhachHang VARCHAR(20) NOT NULL,
    NgayBan DATE NOT NULL,
    TongTien DECIMAL(12) NOT NULL,

    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- 6. Bảng chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaCT INT PRIMARY KEY IDENTITY(1,1),
    MaHoaDon INT NOT NULL,
    MaThuoc VARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
);

-- 7. Bảng phiếu nhập
CREATE TABLE PhieuNhap (
    MaPhieuNhap INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung VARCHAR(10),
    MaNCC VARCHAR(10) NOT NULL,
    NgayNhap DATE NOT NULL,
    GhiChu NVARCHAR(100),

    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- 8. Bảng chi tiết phiếu nhập 
CREATE TABLE ChiTietPhieuNhap (
    MaChiTietPN INT PRIMARY KEY IDENTITY(1,1),
    MaPhieuNhap INT NOT NULL,
    MaThuoc VARCHAR(10) NOT NULL,
    SoLuongNhap INT NOT NULL CHECK (SoLuongNhap > 0),
    HanSuDung DATE NOT NULL,
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
);

INSERT INTO Thuoc (MaThuoc, TenThuoc, LoaiThuoc, DonViTinh, GiaMua, GiaBan, SoLuongTon) VALUES
('TH001', N'Paracetamol', N'Giảm đau hạ sốt', N'Lọ', 5000, 7000, 100),
('TH002', N'Amoxicillin', N'Kháng sinh', N'Viên', 8000, 10000, 50),
('TH003', N'Vitamin C', N'Bổ sung vitamin', N'Viên', 3000, 5000, 200),
('TH004', N'Ibuprofen', N'Giảm đau', N'Vĩ', 6000, 8000, 75),
('TH005', N'Omeprazole', N'Dạ dày', N'Viên', 9000, 12000, 60),
('TH006', N'Cetirizine', N'Chống dị ứng', N'Viên', 4000, 6000, 80),
('TH007', N'Azithromycin', N'Kháng sinh', N'Hộp', 15000, 18000, 40),
('TH008', N'Metformin', N'Tiểu đường', N'Viên', 7000, 9000, 90),
('TH009', N'Losartan', N'Huyết áp', N'Viên', 11000, 14000, 30),
('TH010', N'Clorpheniramin', N'Chống dị ứng', N'Típ', 2000, 3500, 120);
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email) VALUES
('NCC001', N'Công ty Dược Hà Nội', N'12 Lý Thường Kiệt, Hà Nội', '09123456789', 'contact@duochanoi.vn'),
('NCC002', N'Công ty Dược Sài Gòn', N'45 Nguyễn Trãi, TP.HCM', '09876543210', 'info@duocsaigon.vn'),
('NCC003', N'Công ty Dược Bình Dương', N'88 Đại lộ Bình Dương, Bình Dương', '09012345678', 'sales@duocbinhduong.vn'),
('NCC004', N'Công ty Dược Đà Nẵng', N'23 Lê Duẩn, Đà Nẵng', '09345678901', 'support@duocdanang.vn'),
('NCC005', N'Công ty Dược Hải Phòng', N'56 Trần Phú, Hải Phòng', '09456789012', 'info@duochp.vn'),
('NCC006', N'Công ty Dược Quảng Ninh', N'77 Hạ Long, Quảng Ninh', '09567890123', 'contact@duocqn.vn'),
('NCC007', N'Công ty Dược Cần Thơ', N'34 Nguyễn Văn Cừ, Cần Thơ', '09678901234', 'info@duocct.vn'),
('NCC008', N'Công ty Dược Bắc Ninh', N'19 Lý Thái Tổ, Bắc Ninh', '09789012345', 'sales@duocbn.vn'),
('NCC009', N'Công ty Dược Thái Bình', N'101 Trần Hưng Đạo, Thái Bình', '09890123456', 'contact@duoctb.vn'),
('NCC010', N'Công ty Dược Nghệ An', N'202 Quang Trung, Nghệ An', '09901234567', 'info@duocna.vn');
INSERT INTO NguoiDung (MaNguoiDung, TenDangNhap, MatKhau, HoTen, ChucVu, Email, SDT) VALUES
('ND001', 'an.nguyen', 'matkhau123', N'Nguyễn Văn An', N'Quản trị viên', 'an.nguyen@example.com', '09123456789'),
('ND002', 'mai.tran', 'matkhau456', N'Trần Thị Mai', N'Nhân viên', 'mai.tran@example.com', '09876543210'),
('ND003', 'binh.le', 'matkhau789', N'Lê Văn Bình', N'Nhân viên', 'binh.le@example.com', '09012345678'),
('ND004', 'hoa.pham', 'matkhau321', N'Phạm Thị Hoa', N'Kế toán', 'hoa.pham@example.com', '09345678901'),
('ND005', 'tuan.vu', 'matkhau654', N'Vũ Minh Tuấn', N'Nhân viên', 'tuan.vu@example.com', '09456789012'),
('ND006', 'lan.hoang', 'matkhau987', N'Hoàng Thị Lan', N'Nhân viên', 'lan.hoang@example.com', '09567890123'),
('ND007', 'hung.dang', 'matkhauabc', N'Đặng Văn Hùng', N'Nhân viên', 'hung.dang@example.com', '09678901234'),
('ND008', 'huong.bui', 'matkhaudef', N'Bùi Thị Hương', N'Nhân viên', 'huong.bui@example.com', '09789012345'),
('ND009', 'phuc.ngo', 'matkhaugia', N'Ngô Văn Phúc', N'Nhân viên', 'phuc.ngo@example.com', '09890123456'),
('ND010', 'thu.phan', 'matkhauxyz', N'Phan Thị Thu', N'Nhân viên', 'thu.phan@example.com', '09901234567');
INSERT INTO PhieuNhap (MaNguoiDung, MaNCC, NgayNhap, GhiChu) VALUES
( 'ND001', 'NCC001', '2025-06-01', N'Nhập thuốc Paracetamol'),
( 'ND002', 'NCC002', '2025-06-02', N'Nhập thuốc Amoxicillin'),
( 'ND003', 'NCC003', '2025-06-03', N'Nhập thuốc Vitamin C'),
( 'ND004', 'NCC004', '2025-06-04', N'Nhập thuốc Ibuprofen'),
( 'ND005', 'NCC005', '2025-06-05', N'Nhập thuốc Omeprazole'),
( 'ND006', 'NCC006', '2025-06-06', N'Nhập thuốc Cetirizine'),
( 'ND007', 'NCC007', '2025-06-07', N'Nhập thuốc Azithromycin'),
( 'ND008', 'NCC008', '2025-06-08', N'Nhập thuốc Metformin'),
( 'ND009', 'NCC009', '2025-06-09', N'Nhập thuốc Losartan'),
( 'ND010', 'NCC010', '2025-06-10', N'Nhập thuốc Clorpheniramin');
INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaThuoc, SoLuongNhap, HanSuDung) VALUES
(1, 'TH001', 100, '2026-06-01'),
(2, 'TH002', 50, '2026-06-02'),
(3, 'TH003', 200, '2026-06-03'),
(4, 'TH004', 75, '2026-06-04'),
(5, 'TH005', 60, '2026-06-05'),
(6, 'TH006', 80, '2026-06-06'),
(7, 'TH007', 40, '2026-06-07'),
(8, 'TH008', 90, '2026-06-08'),
(9, 'TH009', 30, '2026-06-09'),
(10, 'TH010', 120, '2026-06-10');
-- Sample data for KhachHang table
INSERT INTO KhachHang (MaKhachHang, HoTenKH, NgaySinh, DiaChi, SDT, Email) VALUES
('KH001', N'Nguyễn Văn A', '1990-05-12', N'123 Lê Lợi, Hà Nội', '09123456789', 'nguyenvana@gmail.com'),
('KH002', N'Trần Thị B', '1985-08-23', N'45 Trần Phú, Đà Nẵng', '09876543210', 'tranthib@gmail.com'),
('KH003', N'Lê Minh C', '1992-11-30', N'78 Nguyễn Huệ, TP.HCM', '09012345678', 'leminhc@gmail.com'),
('KH004', N'Phạm Quang D', '1988-03-15', N'56 Hai Bà Trưng, Hải Phòng', '09345678901', 'phamquangd@gmail.com'),
('KH005', N'Hoàng Thị E', '1995-07-20', N'89 Lý Thường Kiệt, Cần Thơ', '09456789012', 'hoangthie@gmail.com'),
('KH006', N'Vũ Văn F', '1993-09-10', N'12 Phan Đình Phùng, Huế', '09567890123', 'vuvan.f@gmail.com'),
('KH007', N'Đặng Thị G', '1987-12-05', N'34 Nguyễn Trãi, Quảng Ninh', '09678901234', 'dangthig@gmail.com'),
('KH008', N'Bùi Quốc H', '1991-04-18', N'67 Trường Chinh, Bình Dương', '09789012345', 'buiquoch@gmail.com'),
('KH009', N'Ngô Thị I', '1996-06-25', N'101 Võ Văn Kiệt, Đồng Nai', '09890123456', 'ngothii@gmail.com'),
('KH010', N'Phan Văn J', '1989-10-02', N'23 Nguyễn Văn Cừ, Bắc Ninh', '09901234567', 'phanvanj@gmail.com');
INSERT INTO HoaDon (MaHoaDon, MaNguoiDung, MaKhachHang, NgayBan, TongTien) VALUES
(1001, 'ND001', 'KH001', '2025-08-01', 1500000),
(1002, 'ND002', 'KH002', '2025-08-02', 2300000),
(1003, 'ND003', 'KH003', '2025-07-03', 1750000),
(1004, 'ND004', 'KH004', '2025-09-04', 2100000),
(1005, 'ND005', 'KH005', '2025-06-05', 1950000),
(1006, 'ND001', 'KH006', '2025-10-06', 2500000),
(1007, 'ND002', 'KH007', '2025-06-07', 1800000),
(1008, 'ND003', 'KH008', '2025-06-08', 2200000),
(1009, 'ND004', 'KH009', '2025-06-09', 1600000),
(1010, 'ND005', 'KH010', '2025-06-10', 2000000);
-- Sample data for ChiTietHoaDon table
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, DonGia) VALUES
(1001, 'TH001', 2, 750000),
(1002, 'TH002', 1, 2300000),
(1003, 'TH003', 3, 583333),
(1004, 'TH004', 5, 420000),
(1005, 'TH005', 2, 975000),
(1006, 'TH006', 1, 2500000),
(1007, 'TH007', 4, 450000),
(1008, 'TH008', 2, 1100000),
(1009, 'TH009', 1, 1600000),
(1010, 'TH010', 3, 666666);