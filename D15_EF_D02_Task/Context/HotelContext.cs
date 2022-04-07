using D15_EF_D02_Task.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_EF_D02_Task.Context
{
    public class HotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog= HotelReservation;" +
                "Integrated Security= True; TrustServerCertificate=true;");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Fluent API

            //modelBuilder.Entity<Reservation>()
            //    .HasKey(r => r.Id);

            //modelBuilder.Entity<Reservation>().Property(r => r.FirstName)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.LastName)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.BirthDay)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.Gender)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.PhoneNumber)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.Email)
            //    .IsRequired(true)
            //    .HasColumnType("nvarchar(MAX)");

            //modelBuilder.Entity<Reservation>().Property(r => r.NumberGuest)
            //   .IsRequired(true);

            //modelBuilder.Entity<Reservation>().Property(r => r.StreetAddress)
            //   .IsRequired(true)
            //   .HasColumnType("nvarchar(MAX)");

            //modelBuilder.Entity<Reservation>().Property(r => r.AptSuite)
            //   .IsRequired(true);

            // modelBuilder.Entity<Reservation>().Property(r => r.City)
            //   .IsRequired(true)
            //   .HasColumnType("nvarchar(MAX)");

            // modelBuilder.Entity<Reservation>().Property(r => r.State)
            //   .IsRequired(true)
            //   .HasMaxLength(50);


            //modelBuilder.Entity<Reservation>().Property(r => r.ZipCode)
            //   .IsRequired(true)
            //   .HasMaxLength(10);

            //modelBuilder.Entity<Reservation>().Property(r => r.RoomType)
            //   .IsRequired(true)
            //   .HasMaxLength(10);

            // modelBuilder.Entity<Reservation>().Property(r => r.RoomFloor)
            //   .IsRequired(true)
            //   .HasMaxLength(10);

            // modelBuilder.Entity<Reservation>().Property(r => r.RoomNumber)
            //   .IsRequired(true)
            //   .HasMaxLength(10);


            //modelBuilder.Entity<Reservation>().Property(r => r.TotolBill)
            //  .IsRequired(true);


            //modelBuilder.Entity<Reservation>().Property(r => r.PaymentType)
            //    .IsRequired(true)
            //    .HasMaxLength(10);

            //modelBuilder.Entity<Reservation>().Property(r => r.CardType)
            //    .IsRequired(true)
            //    .HasMaxLength(10);

            //modelBuilder.Entity<Reservation>().Property(r => r.CardNumber)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.CardExp)
            //    .IsRequired(true)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Reservation>().Property(r => r.CardCvc)
            //    .IsRequired(true)
            //    .HasMaxLength(10);


            //modelBuilder.Entity<Reservation>().Property(r => r.ArrivalTime)
            //   .IsRequired(true);

            //modelBuilder.Entity<Reservation>().Property(r => r.LeavingTime)
            //   .IsRequired(true);

            //modelBuilder.Entity<Reservation>().Property(r => r.CheckIn)
            //   .IsRequired(true)
            //   .HasColumnType("bit");

            //modelBuilder.Entity<Reservation>().Property(r => r.BreakFast)
            //  .IsRequired(true);

            //modelBuilder.Entity<Reservation>().Property(r => r.Lunch)
            //  .IsRequired(true);

            //modelBuilder.Entity<Reservation>().Property(r => r.Dinner)
            //  .IsRequired(true);

            //modelBuilder.Entity<Reservation>().Property(r => r.Cleaning)
            //  .IsRequired(true)
            //  .HasColumnType("bit");

            //modelBuilder.Entity<Reservation>().Property(r => r.Towel)
            //  .IsRequired(true)
            //  .HasColumnType("bit");

            //modelBuilder.Entity<Reservation>().Property(r => r.Ssurprise)
            //  .IsRequired(true)
            //  .HasColumnType("bit");

            //modelBuilder.Entity<Reservation>().Property(r => r.SupplyStatus)
            //  .IsRequired(true)
            //  .HasColumnType("bit");


            //modelBuilder.Entity<Reservation>().Property(r => r.FoodBill)
            //.IsRequired(true);

            #endregion

            /// 4. Configration Class
            modelBuilder.ApplyConfiguration(new ReservationConfigration());

            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<LogInFrontEnd> LogInFrontEnd { get; set; }
        public virtual DbSet<LogInKitchen> LogInKitchen { get; set; }
    }
}
