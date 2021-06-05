create table tb_menu (
id varchar(20) primary key not null,
name varchar(50),
price int,
photo varchar(20))

create table tb_member(
id varchar(20) primary key not null,
name varchar(100) ,
email varchar(100),
telp varchar(20),
joindate date)

create table tb_role(
id int primary key not null identity(1,1),
role varchar(50))


create table tb_employee(
id varchar(20) primary key not null,
name varchar(100) ,
email varchar(50),
password varchar(50),
telp varchar(20),
role varchar(20))

create table tb_head_order(
id varchar(20) primary key not null,
employee_id varchar(20) foreign key references tb_employee(id),
member_id varchar(20) foreign key references tb_member(id),
date date,
payment varchar(50),
bank varchar(50))


create table tb_detail_order(
id int primary key not null,
order_id varchar(20) foreign key references tb_head_order(id),
menu_id varchar(20) foreign key references tb_menu(id),
qty int,
price int,
status varchar(100)) 


