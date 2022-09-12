--CREATE DATABASE CarComparison;
drop table if exists Car, FuelPrice, Model, Brand, FuelType;


CREATE TABLE [FuelType]
(
	[FuelName] VARCHAR(10) PRIMARY KEY
)

CREATE TABLE [Brand]
(
	[BName] VARCHAR(30) PRIMARY KEY
)

CREATE TABLE [Model]
(
	[MName] VARCHAR(50) PRIMARY KEY
)

CREATE TABLE [FuelPrice]
(
	[FPId] INT IDENTITY(0,1) PRIMARY KEY,
	[FuelName] VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES FuelType(FuelName),
	[Date] DATETIME,
	[Price] FLOAT NOT NULL

)

CREATE TABLE [Car]
(
	[CarId] int primary key not null identity(1,1),
	[Variant] VARCHAR(150),
	[ReleaseYear] DATE,
	[FuelUsagePerKM] FLOAT NOT NULL,
	[Price] FLOAT NOT NULL,
	[MName] VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Model(MName),
	[BName] VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Brand(BName),
	[FuelName] VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES FuelType(FuelName)
)
