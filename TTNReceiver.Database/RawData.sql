CREATE TABLE [dbo].[RawData]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Data] varbinary(50) null,
	[DeviceId] int,
	[Timestamp] datetime2
)
