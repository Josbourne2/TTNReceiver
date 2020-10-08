CREATE TABLE [dbo].[Devices]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [DeviceKey] VARCHAR(50) NOT NULL, 
    [DeviceTypeId] SMALLINT NULL, 
    CONSTRAINT [FK_Devices_ToDeviceType] FOREIGN KEY ([DeviceTypeId]) REFERENCES [Devices]([Id]),

)
