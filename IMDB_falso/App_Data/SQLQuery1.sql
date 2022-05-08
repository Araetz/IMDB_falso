/*CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [FirstName] NVARCHAR(50) NULL, 
    [SecondName] NVARCHAR(50) NULL, 
    [Origin] NVARCHAR(3) NULL, 
    [Birth] DATETIME2 NULL, 
    [Deatch] DATETIME2 NULL, 
    [Picture] NTEXT NULL
)*/
INSERT INTO [Person] (FirstName,SecondName,Origin)
VALUES ('Samuel','Jackson','USA')