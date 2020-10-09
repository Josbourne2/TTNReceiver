CREATE TABLE [dbo].[Measurements]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] varchar(50) NULL,
    [DeviceId] INT NOT NULL, 
    [Timestamp] DATETIME2 NULL, 
    [Value] DECIMAL(18, 2) NULL, 
    CONSTRAINT [FK_Measurements_ToDevices] FOREIGN KEY ([DeviceId]) REFERENCES [Devices]([Id])
)
