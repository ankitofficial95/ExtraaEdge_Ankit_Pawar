Create table Brand(
BrandId int primary key identity(1,1),
Brandname varchar(30),
BrandDescription varchar(30)
);


Create table Mobile(
MobileId int primary key identity(1,1),
model varchar(30),
MobileDescription varchar(30),
MobilePrice int,
BrandId int
);

Alter table mobile add constraint Fk_BrandId foreign key(Brandid) references Brand(Brandid)

Create table Customer(
CustomerId int primary key identity(1,1),
CustomerName varchar(30),
CustomerAdress varchar(30),

);
select * from customer
select * from brand

Create table Sell(
sellId int primary key identity(1,1),
customerId int,
selldate date,
SellPrice int,
discount int,
finalprice int

);
Alter table Sell add constraint Fk_custId foreign key(customerid) references customer(customerid)
 



select * from brand
select * from mobile
select * from customer
select * from sell

