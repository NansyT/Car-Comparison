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