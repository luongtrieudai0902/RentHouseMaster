CREATE DATABASE QuanLyThueNha;
GO

USE QuanLyThueNha;
GO

-- Entity Relationship Diagram for Rental Management System

CREATE TABLE UserAccount (
    ID_User INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE,
    PasswordHash VARBINARY(64) NOT NULL,  -- Lưu mật khẩu mã hóa SHA-256
    Role VARCHAR(20) CHECK (Role IN ('ChuNha', 'NhanVien', 'KhachThue')) NOT NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    SoDienThoai VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE Owner (
    ID_ChuNha INT PRIMARY KEY,
    ID_User INT UNIQUE,
    Ten VARCHAR(255),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    DiaChi VARCHAR(MAX),  -- Đổi TEXT thành VARCHAR(MAX)
    FOREIGN KEY (ID_User) REFERENCES UserAccount(ID_User)
);

CREATE TABLE Tenant (
    ID_KhachThue INT PRIMARY KEY,
    ID_User INT UNIQUE,
    HoTen VARCHAR(255),
    NgaySinh DATE,
    CMND_CCCD VARCHAR(50),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    DiaChi VARCHAR(MAX),
    FOREIGN KEY (ID_User) REFERENCES UserAccount(ID_User)
);

CREATE TABLE Employee (
    ID_NhanVien INT PRIMARY KEY,
    ID_User INT UNIQUE,
    HoTen VARCHAR(255),
    ChucVu VARCHAR(100),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    FOREIGN KEY (ID_User) REFERENCES UserAccount(ID_User)
);

CREATE TABLE Property (
    ID_Phong INT PRIMARY KEY,
    ID_ChuNha INT,
    DiaChi VARCHAR(MAX),
    LoaiPhong VARCHAR(100),
    GiaThue DECIMAL(10,2),
    TrangThai VARCHAR(10) CHECK (TrangThai IN ('ConTrong', 'DaThue')),
    FOREIGN KEY (ID_ChuNha) REFERENCES Owner(ID_ChuNha)
);

CREATE TABLE RentalContract (
    ID_HopDong INT PRIMARY KEY,
    ID_KhachThue INT,
    ID_Phong INT,
    NgayBatDau DATE,
    NgayKetThuc DATE,
    TienCoc DECIMAL(10,2),
    TrangThai VARCHAR(10) CHECK (TrangThai IN ('HieuLuc', 'HetHan', 'HuyBo')),
    FOREIGN KEY (ID_KhachThue) REFERENCES Tenant(ID_KhachThue),
    FOREIGN KEY (ID_Phong) REFERENCES Property(ID_Phong)
);

CREATE TABLE Invoice (
    ID_HoaDon INT PRIMARY KEY,
    ID_HopDong INT,
    NgayLap DATE,
    TongTien DECIMAL(10,2),
    TrangThaiThanhToan VARCHAR(15) CHECK (TrangThaiThanhToan IN ('ChuaThanhToan', 'DaThanhToan')),
    FOREIGN KEY (ID_HopDong) REFERENCES RentalContract(ID_HopDong)
);

CREATE TABLE Service (
    ID_DichVu INT PRIMARY KEY,
    TenDichVu VARCHAR(255),
    DonGia DECIMAL(10,2)
);

CREATE TABLE UtilityRecord (
    ID_ChiSo INT PRIMARY KEY,
    ID_HopDong INT,
    ThangNam DATE,
    ChiSoDienCu INT,
    ChiSoDienMoi INT,
    ChiSoNuocCu INT,
    ChiSoNuocMoi INT,
    FOREIGN KEY (ID_HopDong) REFERENCES RentalContract(ID_HopDong)
);

CREATE TABLE Vehicle (
    ID_PhuongTien INT PRIMARY KEY,
    ID_KhachThue INT,
    BienSoXe VARCHAR(20),
    LoaiXe VARCHAR(50),
    ChoDauXe VARCHAR(50),
    FOREIGN KEY (ID_KhachThue) REFERENCES Tenant(ID_KhachThue)
);

INSERT INTO UserAccount (Username, PasswordHash, Role, Email, SoDienThoai)
VALUES 
('owner1', HASHBYTES('SHA2_256', CONVERT(VARCHAR, '123456')), 'ChuNha', 'owner1@example.com', '0901234567'),
('employee1', HASHBYTES('SHA2_256', CONVERT(VARCHAR, '123456')), 'NhanVien', 'employee1@example.com', '0912345678'),
('tenant1', HASHBYTES('SHA2_256', CONVERT(VARCHAR, '123456')), 'KhachThue', 'tenant1@example.com', '0923456789');
SELECT * FROM UserAccount;

USE QuanLyThueNha;
CREATE LOGIN TestUser WITH PASSWORD = 'YourStrongPassword';
CREATE USER TestUser FOR LOGIN TestUser;
ALTER ROLE db_owner ADD MEMBER TestUser;

SELECT name, type_desc FROM sys.database_principals;


INSERT INTO UserAccount(Username, PasswordHash, Role, Email, SoDienThoai) VALUES
('Triều Đại', HASHBYTES('SHA2_256', CONVERT(VARCHAR, 'trieudai')), 'KhachThue', 'luongtrieudai@gmail.com', '0927094519');

-- Tạo bảng Guests (Khách lưu trú)
CREATE TABLE Guests (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    BirthDate DATE NOT NULL,
    IdType NVARCHAR(50) NOT NULL,
    IdNumber NVARCHAR(50) NOT NULL,
    Nationality NVARCHAR(50) NOT NULL,
    Province NVARCHAR(50) NOT NULL,
    District NVARCHAR(50) NOT NULL,
    Ward NVARCHAR(50) NOT NULL,
    Address NVARCHAR(200) NOT NULL
);

-- Tạo bảng Accommodations (Đăng ký lưu trú)
CREATE TABLE Accommodations (
    Id INT PRIMARY KEY IDENTITY(1,1),
    GuestId INT NOT NULL,
    AccommodationPlace NVARCHAR(100) NOT NULL,
    Room NVARCHAR(50) NOT NULL,
    CheckInDate DATETIME NOT NULL,
    FOREIGN KEY (GuestId) REFERENCES Guests(Id)
);