CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] VARCHAR(50) NOT NULL, 
    [DeviceKey] VARCHAR(50) NOT NULL, 
    [DeviceTypeId] INT NULL, 
    CONSTRAINT [FK_Devices_ToDeviceType] FOREIGN KEY ([DeviceTypeId]) REFERENCES [Devices]([Id]),

)
