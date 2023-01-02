/* Creating the database */
create database CarComparison;

/* Creating the tables */
use CarComparison;

create table FuelType 
(
	FuelName varchar(10) primary key
);

create table Brand 
(
	BName varchar(30) primary key
);

create table Model
(
	MName varchar(50) primary key
);

create table FuelPrice
(
	FPId int auto_increment primary key,
    FuelName varchar(10) not null,
    foreign key (FuelName) references FuelType(FuelName),
    Date datetime,
    Price float not null
);

create table Car
(
	CarId int primary key auto_increment,
    Variant varchar(150),
    ReleaseYear date,
    FuelUsagePerKM float not null,
    Price float not null,
    MName varchar(50) not null,
    foreign key (MName) references Model(MName),
    BName varchar(30) not null,
    foreign key (BName) references Brand(BName),
    FuelName varchar(10) not null,
    foreign key (FuelName) references FuelType(FuelName)
);