using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TTNReceiver.Core;

namespace TTNReceiver.Data
{
    public class TTNReceiverDataContext : IdentityDbContext
    {
        public TTNReceiverDataContext(DbContextOptions<TTNReceiverDataContext> options) : base(options)
        {

        }

        public virtual DbSet<Device> Devices { get; set; }

        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }
        public virtual DbSet<RawData> RawData { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Regel dat Identity werkt
            base.OnModelCreating(builder);

            builder.Entity<Device>().ToTable("Devices");
            builder.Entity<DeviceType>().ToTable("DeviceTypes");
            builder.Entity<Measurement>().ToTable("Measurements");
            builder.Entity<RawData>().ToTable("RawData");

            ConfigureDeviceTypes(builder);
            ConfigureDevices(builder);
            ConfigureMeasurements(builder);
            ConfigureRawData(builder);
        }

        private void ConfigureRawData(ModelBuilder builder)
        {
            //Id
            builder.Entity<RawData>()
                .Property(r => r.Id)
                .HasColumnType("int");

            builder.Entity<RawData>()
                .Property(r => r.Data)
                .HasColumnType("varbinary(50)");

            builder.Entity<RawData>()
                .Property(r => r.DeviceId)
                .HasColumnType("smallint");

            builder.Entity<RawData>()
                .Property(r => r.Timestamp)
                .HasColumnType("datetime2");

            //FK_Devices_ToDeviceType
            builder.Entity<RawData>()
                .HasOne(e => e.Device)
                .WithMany(e => e.RawData)
                .HasForeignKey("DeviceId");
        }

        private void ConfigureMeasurements(ModelBuilder builder)
        {
            builder.Entity<Measurement>()
                .Property(m => m.Id)
                .HasColumnType("int");

            builder.Entity<Measurement>()
                .Property(m => m.Name)
                .HasColumnType("varchar(50)");

            builder.Entity<Measurement>()
                .Property(m => m.Value)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Measurement>()
                .Property(m => m.Timestamp)
                .HasColumnType("datetime2");

            //builder.Entity<Measurement>()
            //    .HasOne(m => m.Device)
            //    .WithMany(m => m.Measurements)
            //    .HasForeignKey("DeviceId");
        }

        private void ConfigureDevices(ModelBuilder builder)
        {
            // Id
            builder.Entity<Device>()
                .Property(l => l.Id)
                .HasColumnType("smallint");

            // Name
            builder.Entity<Device>()
               .Property(l => l.Name)
               .HasColumnType("varchar(50)");

            // Name
            builder.Entity<Device>()
               .Property(l => l.DeviceKey)
               .HasColumnType("varchar(50)");

            //FK_Devices_ToDeviceType
            //builder.Entity<Device>()
            //    .HasOne(e => e.DeviceType)
            //    .WithMany(e => e.Devices)
            //    .HasForeignKey("DeviceTypeId");

            builder.Entity<Device>()
               .Property(e => e.DeviceTypeId)
               .HasColumnType("smallint");
        }

        private void ConfigureDeviceTypes(ModelBuilder builder)
        {
            // Id
            builder.Entity<DeviceType>()
                .Property(l => l.Id)
                .HasColumnType("smallint");

            // Name
            builder.Entity<DeviceType>()
               .Property(l => l.Name)
               .HasColumnType("varchar(50)");

            // Description
            builder.Entity<DeviceType>()
               .Property(l => l.JSDecodeFunction)
               .HasColumnType("varchar(8000)");
        }
    }
}