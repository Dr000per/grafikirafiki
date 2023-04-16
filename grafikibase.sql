use DZ_grafik;

create table PriceCat(
ID int identity(1,1) primary key not null,
Name varchar(50) not null
);
create table tovar(
ID int identity(1,1) primary key not null,
ID_price_cat int references PriceCat(ID) not null,
Article varchar(50) not null,
Name varchar(50) not null,
Price decimal(10,2) not null
);

insert into PriceCat values ('До 5.000р'), ('От 5.000р до 10.000р'), ('От 10.000р');

insert into tovar values (1, 'DFDSF12', 'Стул', 2000),
(3, '6DSDG12', 'Телевизор', 76412),
(1, 'D42SF12', 'Стол', 2250),
(2, 'GGG122', 'Лампа', 8000),
(1, 'KFFNDS', 'Коврик', 1500);