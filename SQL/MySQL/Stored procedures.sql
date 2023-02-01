DELIMITER $$
use carcomparison; $$
/* Stored Procedures */
drop procedure if exists GetCars;$$

CREATE PROCEDURE GetCars()
begin
	declare gasPrice float;
    declare elPrice float;
    
	set gasPrice = (select (SELECT Avg(Price) from fuelprice where FuelName = 'Benzin')
	from fuelprice where Date > timestampadd(day, -320, now()) and fuelprice.FuelName = 'Benzin' LIMIT 1);
	
	set elPrice = (select (SELECT Avg(Price) from fuelprice where FuelName = 'El')  
	from fuelprice where Date > timestampadd(day, -320, now()) and fuelprice.FuelName = 'El' LIMIT 1);

	SELECT car.*, case when car.FuelName = 'Benzin' then gasPrice else elPrice end as AvgPrice
	from car order by BName, MName, Variant;
end $$

drop procedure if exists GetBrands;$$

CREATE PROCEDURE GetBrands()
begin
	select * from brand;
end $$

drop procedure if exists GetModelsByBrand;$$

CREATE PROCEDURE GetModelsByBrand(brand varchar(30))
begin
	Select MName from car where BName = brand;
end $$

drop procedure if exists GetVariantByModel;$$

CREATE PROCEDURE GetVariantByModel(model varchar(50))
begin
	Select Variant from car where MName = model;
end $$

drop procedure if exists GetYears;$$

CREATE PROCEDURE GetYears(brand varchar(30), variants varchar(150), model varchar(50))
begin
	Select YEAR(ReleaseYear) from car where BName = brand and MName = model and Variant = variants;
end $$