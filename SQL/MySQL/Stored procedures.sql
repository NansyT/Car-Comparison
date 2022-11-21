DELIMITER $$
use carcomparison; $$
/* Stored Procedures */
drop procedure if exists GetCars;$$

CREATE PROCEDURE GetCars()
begin
	declare gasPrice float;
    declare elPrice float;
    
	set gasPrice = (select (SELECT Avg(Price) from FuelPrice where FuelName = 'Benzin')
	from FuelPrice where Date > timestampadd(day, -320, now()) and FuelPrice.FuelName = 'Benzin' LIMIT 1);
	
	set elPrice = (select (SELECT Avg(Price) from FuelPrice where FuelName = 'El')  
	from FuelPrice where Date > timestampadd(day, -120, now()) and FuelPrice.FuelName = 'El' LIMIT 1);

	SELECT Car.*, case when Car.FuelName = 'Benzin' then gasPrice else elPrice end as AvgPrice
	from Car;
end $$

drop procedure if exists GetBrands;$$

CREATE PROCEDURE GetBrands()
begin
	select * from Brand;
end $$

drop procedure if exists GetModelsByBrand;$$

CREATE PROCEDURE GetModelsByBrand(Brand varchar(30))
begin
	Select MName from Car where BName = Brand;
end $$

drop procedure if exists GetVariantByModel;$$

CREATE PROCEDURE GetVariantByModel(model varchar(50))
begin
	Select Variant from Car where MName = model;
end $$

drop procedure if exists GetYears;$$

CREATE PROCEDURE GetYears(brand varchar(30), variants varchar(150), model varchar(50))
begin
	Select YEAR(ReleaseYear) from Car where BName = brand and MName = model and Variant = variants;
end $$