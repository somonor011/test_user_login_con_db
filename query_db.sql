create database db_user_login_charp;

create table tbl_user_login_charp(
	id int primary key,
	username nvarchar(20),
	passwordd nvarchar(20)
)

insert into tbl_user_login_charp (id,username,passwordd)
	values(1,'somonor','smn123')

select * from tbl_user_login_charp