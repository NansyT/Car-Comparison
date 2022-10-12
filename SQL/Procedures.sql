CREATE OR ALTER PROCEDURE GetCars
AS
	declare @gasPrice float;

	select Top 1 @gasPrice = (SELECT Avg(Price) from FuelPrice where FuelName = 'Benzin')  

   from FuelPrice where Date > DATEADD(day, -320, GetDate()) and FuelPrice.FuelName = 'Benzin';

  


   declare @ElPrice float;

	select Top 1 @ElPrice = (SELECT Avg(Price) from FuelPrice where FuelName = 'El')  

   from FuelPrice where Date > DATEADD(day, -120, GetDate()) and FuelPrice.FuelName = 'El';

 

   SELECT Car.*, case when Car.FuelName = 'Benzin' then  @gasPrice else @ElPrice end as AvgPrice
   from Car
GO


CREATE OR ALTER PROCEDURE GetBrands
AS
	select * from Brand
GO

CREATE or ALTER PROCEDURE GetModelsByBrand @Brand varchar(30)
AS
	Select MName from car where BName = @Brand;
GO

CREATE or ALTER PROCEDURE GetVariantByModel @model varchar(50)
AS
	Select Variant from car where MName = @model;
GO

CREATE or ALTER PROCEDURE GetYears @brand varchar(30), @variant varchar(150), @model varchar(50)
AS
	Select YEAR(ReleaseYear) from car where MName = @model;
GO