CREATE TABLE LoaiPhim (
    MaLoaiPhim CHAR(4) PRIMARY KEY,
    TenLoaiPhim NVARCHAR(255)
);

CREATE TABLE Phim (
    MaPhim CHAR(4) PRIMARY KEY,
    TenPhim NVARCHAR(255),
    NgayRaMat DATE,
    MaLoaiPhim CHAR(4),
    FOREIGN KEY (MaLoaiPhim) REFERENCES LoaiPhim(MaLoaiPhim)
);

CREATE TABLE PhongChieu (
    MaPhongChieu CHAR(4) PRIMARY KEY,
    TenPhongChieu NVARCHAR(255)
);

CREATE TABLE LichChieu (
    MaLichChieu CHAR(4) PRIMARY KEY,
    MaPhim CHAR(4),
    MaPhongChieu CHAR(4),
    NgayChieu DATE,
    GioChieu TIME,
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim),
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
);

CREATE TABLE KhachHang (
    MaKhachHang CHAR(4) PRIMARY KEY,
    TenKhachHang NVARCHAR(255),
    DiaChi VARCHAR(255),
    DienThoai VARCHAR(20)
);

CREATE TABLE Ve (
    MaVe CHAR(4) PRIMARY KEY,
    MaLichChieu CHAR(4),
    MaKhachHang CHAR(4),
    GiaVe INT,
    FOREIGN KEY (MaLichChieu) REFERENCES LichChieu(MaLichChieu),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE NhanVien (
    MaNhanVien CHAR(4) PRIMARY KEY,
    TenNhanVien NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(20)
);

CREATE TABLE TaiKhoan (
    MaTaiKhoan CHAR(4) PRIMARY KEY,
    TaiKhoan VARCHAR(255),
    MatKhau VARCHAR(255),
    MaNhanVien CHAR(4),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Loai Phim
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP01', 'Phim hanh đong');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP02', 'Phim tinh cam');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP03', 'Phim hoat hinh');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP04', 'Phim kinh di');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP05', 'Phim vien tưong');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP06', 'Phim phiêu lưu');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP07', 'Phim hai');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP08', 'Phim chien tranh');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP09', 'Phim tai lieu');
INSERT INTO LoaiPhim (MaLoaiPhim, TenLoaiPhim) VALUES ('LP10', 'Phim tam ly');

-- Phim
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P001', 'Avengers: Endgame', '2019-04-26', 'LP05');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P002', 'Fast & Furious 9', '2021-05-19', 'LP01');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P003', 'Titanic', '1997-12-19', 'LP02');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P004', 'Frozen', '2013-11-22', 'LP03');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P005', 'The Shining', '1980-06-13', 'LP04');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P006', 'Interstellar', '2014-11-07', 'LP05');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P007', 'Indiana Jones and the Raiders of the Lost Ark', '1981-06-12', 'LP06');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P008', 'Home Alone', '1990-11-16', 'LP07');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P009', 'Saving Private Ryan', '1998-07-24', 'LP08');
INSERT INTO Phim (MaPhim, TenPhim, NgayRaMat, MaLoaiPhim) VALUES ('P010', 'The Social Dilemma', '2020-09-09', 'LP09');

-- Phong Chieu
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC01', 'Phong chieu so 1');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC02', 'Phong chieu so 2');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC03', 'Phong chieu so 3');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC04', 'Phong chieu so 4');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC05', 'Phong chieu so 5');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC06', 'Phong chieu so 6');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC07', 'Phong chieu so 7');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC08', 'Phong chieu so 8');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC09', 'Phong chieu so 9');
INSERT INTO PhongChieu (MaPhongChieu, TenPhongChieu) VALUES ('PC10', 'Phong chieu so 10');

-- Lich Chieu
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC01', 'P001', 'PC01', '2023-03-18', '14:00:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC02', 'P002', 'PC02', '2023-03-18', '16:30:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC03', 'P003', 'PC03', '2023-03-18', '19:00:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC04', 'P004', 'PC04', '2023-03-19', '12:00:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC05', 'P005', 'PC05', '2023-03-19', '14:30:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC06', 'P006', 'PC06', '2023-03-19', '17:00:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC07', 'P007', 'PC07', '2023-03-20', '10:00:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC08', 'P008', 'PC08', '2023-03-20', '13:30:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC09', 'P009', 'PC09', '2023-03-20', '16:00:00');
INSERT INTO LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GioChieu)
VALUES ('LC10', 'P010', 'PC10', '2023-03-20', '19:00:00');

-- Khach Hang
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, DiaChi, DienThoai) VALUES
('KH01', 'Nguyen Van An', '123 Đuong A, Quan 1, TP.HCM', '0987654321'),
('KH02', 'Tran Thi Binh', '456 Đuong D, Quan 2, TP.HCM', '0123456789'),
('KH03', 'Le Van Cang', '132 Đuong G, Quan 3, TP.HCM', '0912345678'),
('KH04', 'Phạm Thi Dung', '110 Đuong J, Quan 4, TP.HCM', '0123456789'),
('KH05', 'Đo Van Em', '111 Đuong O, Quan 5, TP.HCM', '0987654321'),
('KH06', 'Nguyen Thi Be', '234 Đuong R, Quan 6, TP.HCM', '0912345678'),
('KH07', 'Tran Van Sang', '240 Đuong S, Quan 7, TP.HCM', '0123456789'),
('KH08', 'Le Thi Hong', '468 Đuong V, Quan 8, TP.HCM', '0987654321'),
('KH09', 'Pham Van Dau', '576 Đuong Y, Quan 9, TP.HCM', '0912345678'),
('KH10', 'Đo Thi Khang', '440 Đuong Z, Quan 10, TP.HCM', '0123456789');

-- Ve
INSERT INTO Ve (MaVe, MaLichChieu, MaKhachHang, GiaVe)
VALUES ('V001', 'LC01', 'KH01', 100000),
('V002', 'LC01', 'KH02', 100000),
('V003', 'LC02', 'KH03', 120000),
('V004', 'LC02', 'KH04', 120000),
('V005', 'LC03', 'KH05', 80000),
('V006', 'LC03', 'KH06', 80000),
('V007', 'LC04', 'KH07', 90000),
('V008', 'LC04', 'KH08', 90000),
('V009', 'LC05', 'KH09', 110000),
('V010', 'LC05', 'KH10', 110000);

-- Nhan Vien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV01', 'Nguyen Van An', '1990-01-01', 'Nam', 'Ha Noi', '0123456789');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV02', 'Tran Thi Binh', '1992-03-15', 'Nu', 'Ho Chi Minh', '0987654321');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV03', 'Pham Van Cang', '1995-05-20', 'Nam', 'Da Nang', '0987123456');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV04', 'Cao Hoang An', '1998-08-08', 'Nam', 'Ha Noi', '0909090909');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV05', 'Đo Khanh Toan', '2000-12-25', 'Nam', 'Ha Noi', '0123456789');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV06', 'Le Nguyen Hat', '1997-04-10', 'Nam', 'Ho Chi Minh', '0987654321');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV07', 'Tran Trung Tin', '1999-06-05', 'Nam', 'Da Nang', '0987123456');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV08', 'Nguyen Thi Phuong Thu', '1994-09-30', 'Nu', 'Ha Noi', '0909090909');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV09', 'Nguyen Ngoc Kieu Han', '1996-11-11', 'Nu', 'Ha Noi', '0123456789');

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai)
VALUES ('NV10', 'Tran Owen', '1993-07-20', 'Nam', 'Ho Chi Minh', '0987654321');

-- TaiKhoan
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK01', 'admin', '1234567', 'NV01');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK02', 'user1', '123456', 'NV02');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK03', 'user2', '123456', 'NV03');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK04', 'user3', '123456', 'NV04');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK05', 'user4', '123456', 'NV05');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK06', 'user5', '123456', 'NV06');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK07', 'user6', '123456', 'NV07');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK08', 'user7', '123456', 'NV08');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK09', 'user8', '123456', 'NV09');
INSERT INTO TaiKhoan (MaTaiKhoan, TaiKhoan, MatKhau, MaNhanVien) VALUES ('TK10', 'user9', '123456', 'NV10');
