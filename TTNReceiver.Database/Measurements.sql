CREATE TABLE [dbo].[Measurements]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [Name] varchar(50) NULL,
    [DeviceId] SMALLINT NOT NULL, 
    [Timestamp] DATETIME2 NULL, 
    [Value] DECIMAL(18, 2) NULL, 
    CONSTRAINT [FK_Measurements_ToDevices] FOREIGN KEY ([DeviceId]) REFERENCES [Devices]([Id])
)
