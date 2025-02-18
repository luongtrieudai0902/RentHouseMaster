create database UserInfo;
go
use UserInfo;

create table userList(
	id int identity(1,1) primary key,
	fullName nvarchar(100),
	phoneOrEmail nvarchar(100) unique,
	uPassWord nvarchar(100)
);