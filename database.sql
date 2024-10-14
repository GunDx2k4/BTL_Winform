/* 
Tất cả các id của bài toán đều để tự động tăng nên khi thêm không cần thêm trường id
Tất cả các truy vấn select đều thêm where bDeleted = false, khi xóa thì set bDeleted = true
*/

create database QuanLyThuTienMang

-------------------------- THAO TÁC TẠO BẢNG --------------------------
/*
Tài khoản để đăng nhập vào hệ thống
Cần thao tác thì vào db thao tác, không cần thêm chức năng thêm sửa xóa trong ứng dụng
*/
create table tblTaiKhoan (
	iMaTaiKhoan int identity(1,1) primary key,
	sTaiKhoan nvarchar(100),
	sMatKhau nvarchar(100)
)
insert into tblTaiKhoan
values ('admin', '123123')

create table tblKhachHang (
    iMaKhachHang int identity(1,1) primary key,
    sHoTen nvarchar(100),
    sSoDienThoai nvarchar(15),
    sDiaChi nvarchar(255),
    sEmail nvarchar(100),
    bDeleted bit default 0
)

create table tblNhanVien (
    iMaNhanVien int identity(1,1) primary key,
    sHoTen nvarchar(100),
    sSoDienThoai nvarchar(15),
    sDiaChi nvarchar(255),
    bDeleted bit default 0
)

create table tblMang (
    iMaMang int identity(1,1) primary key,
    sTenMang nvarchar(100),
    sMoTa nvarchar(255),
    iDonGia int,
    bDeleted bit default 0
)

/*
Không nhập tổng tiền, tổng tiền được suy dẫn từ tổng tiền của chi tiết hóa đơn
*/
create table tblHoaDon (
    iMaHoaDon int identity(1,1) primary key,
    iMaKhachHang int,
    iMaNhanVien int,
    dNgayTao date constraint ck_NgayTao check (dNgayTao <= getdate()),
    iTongTien int default 0, -- mặc định tổng tiền là 0
    foreign key (iMaKhachHang) references tblKhachHang(iMaKhachHang),
    foreign key (iMaNhanVien) references tblNhanVien(iMaNhanVien)
)

/*
Không nhập đơn giá, đơn giá được lấy từ mạng thông qua mã mạng khi được create
*/
create table tblChiTietHoaDon (
    iMaChiTietHD int identity(1,1) primary key,
    iMaHoaDon int,
    iMaMang int,
    iDonGia int,
    iSoThangDangKy int,
    foreign key (iMaHoaDon) references tblHoaDon(iMaHoaDon),
    foreign key (iMaMang) references tblMang(iMaMang)
)

------------------------- THAO TÁC INSERT -------------------------
GO
create procedure sp_ThemKhachHang
    @sHoTen nvarchar(100),
    @sSoDienThoai nvarchar(15),
    @sDiaChi nvarchar(255),
    @sEmail nvarchar(100)
as
begin
    insert into tblKhachHang (sHoTen, sSoDienThoai, sDiaChi, sEmail)
    values (@sHoTen, @sSoDienThoai, @sDiaChi, @sEmail);
end;

exec sp_ThemKhachHang @sHoTen = N'Đỗ Phúc Hưng', @sSoDienThoai = '0987654321', @sDiaChi = N'Hà Nội', @sEmail = 'dophuchung@gmail.com'
exec sp_ThemKhachHang @sHoTen = N'Đỗ Tiến Quang', @sSoDienThoai = '0987643321', @sDiaChi = N'Hà Nội', @sEmail = 'dophuchung@gmail.com'
exec sp_ThemKhachHang @sHoTen = N'Nguyễn Mạnh Hiếu', @sSoDienThoai = '0444654321', @sDiaChi = N'Phú Thọ', @sEmail = 'dophuchung@gmail.com'
exec sp_ThemKhachHang @sHoTen = N'Đỗ Tiến Quang', @sSoDienThoai = '0943254321', @sDiaChi = N'Phú Thọ', @sEmail = 'dophuchung@gmail.com'
select * from tblKhachHang

GO
create procedure sp_ThemNhanVien
    @sHoTen nvarchar(100),
    @sSoDienThoai nvarchar(15),
    @sDiaChi nvarchar(255)
as
begin
    insert into tblNhanVien (sHoTen, sSoDienThoai, sDiaChi)
    values (@sHoTen, @sSoDienThoai, @sDiaChi);
end;

exec sp_ThemNhanVien @sHoTen = N'Đỗ Văn A', @sSoDienThoai = '0912345678', @sDiaChi = 'Ho Chi Minh City';
exec sp_ThemNhanVien @sHoTen = N'Đỗ Văn B', @sSoDienThoai = '0914445678', @sDiaChi = 'Ha Noi City';
exec sp_ThemNhanVien @sHoTen = N'Đỗ Văn C', @sSoDienThoai = '0913345678', @sDiaChi = 'Phu Tho City';

GO
create procedure sp_ThemMang
    @sTenMang nvarchar(100),
    @sMoTa nvarchar(255),
    @iDonGia int
as
begin
    insert into tblMang (sTenMang, sMoTa, iDonGia)
    values (@sTenMang, @sMoTa, @iDonGia);
end;
exec sp_ThemMang @sTenMang = 'FPT', @sMoTa = N'Tốc độ cao', @iDonGia = 300000;
exec sp_ThemMang @sTenMang = 'VNPT', @sMoTa = N'Tốc độ thấp', @iDonGia = 200000;
exec sp_ThemMang @sTenMang = 'VIETTEL', @sMoTa = N'Tốc độ cao, giá rẻ', @iDonGia = 500000;

GO
create procedure sp_ThemHoaDon
    @iMaKhachHang int,
    @iMaNhanVien int,
    @dNgayTao date
as
begin
    insert into tblHoaDon (iMaKhachHang, iMaNhanVien, dNgayTao)
    values (@iMaKhachHang, @iMaNhanVien, @dNgayTao);
end;
exec sp_ThemHoaDon @iMaKhachHang = 4, @iMaNhanVien = 1, @dNgayTao = '2024-09-02';
exec sp_ThemHoaDon @iMaKhachHang = 2, @iMaNhanVien = 2, @dNgayTao = '2024-08-02';
exec sp_ThemHoaDon @iMaKhachHang = 3, @iMaNhanVien = 3, @dNgayTao = '2024-07-02';
exec sp_ThemHoaDon @iMaKhachHang = 1, @iMaNhanVien = 3, @dNgayTao = '2024-07-05';

/*
Tự động lấy đơn giá hiện tại của mạng
Cập nhật tổng tiền tại bảng hóa đơn
*/

GO
create procedure sp_ThemChiTietHoaDon
    @iMaHoaDon int,
    @iMaMang int,
    @iSoThangDangKy int
as
begin
    declare @iDonGia int;
    select @iDonGia = iDonGia from tblMang where iMaMang = @iMaMang;

    insert into tblChiTietHoaDon (iMaHoaDon, iMaMang, iDonGia, iSoThangDangKy)
    values (@iMaHoaDon, @iMaMang, @iDonGia, @iSoThangDangKy);

    declare @iTongTienMoi int;
    set @iTongTienMoi = @iDonGia * @iSoThangDangKy;

    update tblHoaDon
    set iTongTien = iTongTien + @iTongTienMoi
    where iMaHoaDon = @iMaHoaDon;
end;
exec sp_ThemChiTietHoaDon @iMaHoaDon = 1, @iMaMang = 1, @iSoThangDangKy = 3;
exec sp_ThemChiTietHoaDon @iMaHoaDon = 1, @iMaMang = 2, @iSoThangDangKy = 2;
exec sp_ThemChiTietHoaDon @iMaHoaDon = 2, @iMaMang = 3, @iSoThangDangKy = 4;