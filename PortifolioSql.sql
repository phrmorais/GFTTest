Create DATABASE GFTTest
GO

Use GFTTest
go
-- Create a new table called '[ClientSector]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[ClientSector]', 'U') IS NOT NULL
DROP TABLE [dbo].[ClientSector]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[ClientSector]
(
    Id int NOT NULL PRIMARY KEY identity,
    Sector varchar(30)
);
GO


INSERT ClientSector(Sector)
VALUES ('Private'),('Public')
GO
IF OBJECT_ID('[dbo].[portifolio]', 'U') IS NOT NULL
DROP TABLE [dbo].[portifolio]
GO
Create TABLE portifolio(Id int NOT NULL PRIMARY KEY identity,
    Value decimal(18,2),
    ClientSectorId int FOREIGN KEY REFERENCES ClientSector(Id))
GO

INSERT portifolio([Value], ClientSectorId)
VALUES (2000000,1), (400000,2),(500000,2),(3000000,2)
GO

SELECT p.[Value], c.Sector, 
case 
    when p.[Value] < 1000000 and c.Sector = 'Public' then 'LowRisk' 
    when p.[Value] > 1000000 and c.Sector = 'Public' then 'MediumRisk' 
    when p.[Value] > 1000000 and c.Sector = 'Private' then 'HighRisk' 
    else 'NoneRisk' END as Risk
FROM portifolio p
inner join ClientSector c on c.Id=p.ClientSectorId
GO

-- Create a new stored procedure called 'GetPortifolioBySector' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetPortifolioBySector'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.GetPortifolioBySector
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.GetPortifolioBySector
  @Sector varchar(30)
AS
BEGIN
    -- body of the stored procedure
    SELECT p.[Value], c.Sector, 
        case 
            when p.[Value] < 1000000 and c.Sector = 'Public' then 'LowRisk' 
            when p.[Value] > 1000000 and c.Sector = 'Public' then 'MediumRisk' 
            when p.[Value] > 1000000 and c.Sector = 'Private' then 'HighRisk' 
            else 'NoneRisk' END as Risk
    FROM portifolio p
    inner join ClientSector c on c.Id=p.ClientSectorId
    where c.Sector = @Sector
END
GO
-- example to execute the stored procedure we just created
EXECUTE dbo.GetPortifolioBySector 'Public'
GO

-- Drop the database 'GFTTest'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Uncomment the ALTER DATABASE statement below to set the database to SINGLE_USER mode if the drop database command fails because the database is in use.
-- ALTER DATABASE GFTTest SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- Drop the database if it exists
IF EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'GFTTest'
)
DROP DATABASE GFTTest
GO