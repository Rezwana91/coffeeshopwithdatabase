--create database CoffeeShopA;

--create table item(iid int identity(1,1) NOT NULL, iname varchar(50) NOT NULL , price float NOT NULL,PRIMARY KEY (iid) );

--insert into item (iname,price) values ('Black',120);
--insert into item (iname,price) values ('Cold',100);
--insert into item (iname,price) values ('Hot',120);

--create table customer(cid int identity(1,1) NOT NULL, cname varchar(50) NOT NULL, addresss varchar(50) NOT NULL, contact varchar(50) NOT NULL,PRIMARY KEY (cid));

--insert into customer (cname,addresss,contact) values ('Arafat Bin Reza','Mirpur-13','01625420852');
--insert into customer (cname,addresss,contact) values ('Rezwana Binte Reza','Mirpur-1','01676234640');
--insert into customer (cname,addresss,contact) values ('Rezaul Karim','Mirpur-2','01721359359');

--create table orders(id int identity(1,1) NOT NULL, quantity int NOT NULL, totalprice varchar(50) NOT NULL,iid int NOT NULL,cid int NOT NULL, PRIMARY KEY (id),FOREIGN KEY (cid) REFERENCES customer(cid),FOREIGN KEY (iid) REFERENCES item(iid));

--select * from orders,customer,item where customername = 'Arafat Bin Reza'

--select * from customer where cid = 1 or name = 'Arafat Bin Reza';

--select price from item where iid = 1;
--select * from orders;

--insert into orders(quantity,totalprice,iid,cid) values (1,240,1,1);


--drop table orders;
--drop table item;
--drop table customer;

--SELECT orders.id, customer.cname,quantity,totalprice
--FROM orders
--INNER JOIN customer ON Orders.cid=customer.cid 
--or
--SELECT orders.id, item.iname
--FROM Orders
--INNER JOIN item ON Orders.iid=item.iid;







