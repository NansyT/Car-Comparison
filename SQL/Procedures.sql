CREATE OR ALTER PROCEDURE GetFilters
AS
	SELECT [Brand].[BName], [Model].[MName] FROM [Brand], [Model];

GO

CREATE OR ALTER PROCEDURE GetCars @brand VARCHAR(30), @model VARCHAR(50), @variant VARCHAR(150), @releaseYear DATE
AS
	SELECT * FROM [Car]
	WHERE
	BName LIKE '%'+@brand+'%'
	AND
	MName LIKE '%'+@model+'%'
	AND
	Variant LIKE '%'+@variant+'%'
GO