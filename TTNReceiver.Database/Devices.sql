CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [EUI] VARCHAR(50) NOT NULL, 
    [DeviceTypeId] INT NULL, 
    CONSTRAINT [FK_Devices_ToDeviceType] FOREIGN KEY ([DeviceTypeId]) REFERENCES [Devices]([Id]),

)
