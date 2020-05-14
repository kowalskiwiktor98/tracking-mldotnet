using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tracking.Database
{
    public partial class MLTrackingContext : DbContext
    {
        public MLTrackingContext()
        {
        }

        public MLTrackingContext(DbContextOptions<MLTrackingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tracking> Tracking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = Environment.GetEnvironmentVariable("trackingConnectionString", EnvironmentVariableTarget.User);
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new Exception("Environment Variable trackingConnectionString is required!");
                }
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tracking", "MLTracking");

                entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.FirstEvent).HasColumnName("first_event");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastEvent).HasColumnName("last_event");

                entity.Property(e => e.ReceiverCityName)
                    .HasColumnName("receiver_city_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiverCountryCode)
                    .HasColumnName("receiver_country_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiverLatitude)
                    .HasColumnName("receiver_latitude")
                    .HasColumnType("numeric(7,4)");

                entity.Property(e => e.ReceiverLongitude)
                    .HasColumnName("receiver_longitude")
                    .HasColumnType("numeric(7,4)");

                entity.Property(e => e.ReceiverZip)
                    .HasColumnName("receiver_zip")
                    .HasMaxLength(20);

                entity.Property(e => e.SenderCityName)
                    .HasColumnName("sender_city_name")
                    .HasMaxLength(100);

                entity.Property(e => e.SenderCountryCode)
                    .HasColumnName("sender_country_code")
                    .HasMaxLength(20);

                entity.Property(e => e.SenderLatitude)
                    .HasColumnName("sender_latitude")
                    .HasColumnType("numeric(7,4)");

                entity.Property(e => e.SenderLongitude)
                    .HasColumnName("sender_longitude")
                    .HasColumnType("numeric(7,4)");

                entity.Property(e => e.SenderZip)
                    .HasColumnName("sender_zip")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentCreatedate).HasColumnName("shipment_createdate");

                entity.Property(e => e.ShipmentIdentcode)
                    .HasColumnName("shipment_identcode")
                    .HasMaxLength(50);

                entity.Property(e => e.UnixDifference).HasColumnName("unix_difference");

                entity.Property(e => e.UnixFirstEvent).HasColumnName("unix_first_event");

                entity.Property(e => e.UnixLastEvent).HasColumnName("unix_last_event");

                entity.Property(e => e.UnixShipmentCreatedate).HasColumnName("unix_shipment_createdate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
