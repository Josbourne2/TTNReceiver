CREATE TABLE [dbo].[DeviceTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] VARCHAR(50) NULL, 
    [JSDecoderFunction] VARCHAR(8000) NULL
)
