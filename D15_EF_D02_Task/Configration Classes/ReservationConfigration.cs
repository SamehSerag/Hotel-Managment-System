using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D15_EF_D02_Task.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D15_EF_D02_Task
{
    public class ReservationConfigration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(r => r.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

           builder.Property(r => r.BirthDay)
                .IsRequired(true)
                .HasMaxLength(50);

           builder.Property(r => r.Gender)
                .IsRequired(true)
                .HasMaxLength(50);

           builder.Property(r => r.PhoneNumber)
                .IsRequired(true)
                .HasMaxLength(50);

           builder.Property(r => r.Email)
                .IsRequired(true)
                .HasColumnType("nvarchar(MAX)");

           builder.Property(r => r.NumberGuest)
               .IsRequired(true);

           builder.Property(r => r.StreetAddress)
               .IsRequired(true)
               .HasColumnType("nvarchar(MAX)");

           builder.Property(r => r.AptSuite)
               .IsRequired(true);

           builder.Property(r => r.City)
              .IsRequired(true)
              .HasColumnType("nvarchar(MAX)");

           builder.Property(r => r.State)
              .IsRequired(true)
              .HasMaxLength(50);


           builder.Property(r => r.ZipCode)
               .IsRequired(true)
               .HasMaxLength(10);

           builder.Property(r => r.RoomType)
               .IsRequired(true)
               .HasMaxLength(10);

           builder.Property(r => r.RoomFloor)
              .IsRequired(true)
              .HasMaxLength(10);

           builder.Property(r => r.RoomNumber)
              .IsRequired(true)
              .HasMaxLength(10);


           builder.Property(r => r.TotalBill)
              .IsRequired(true);


           builder.Property(r => r.PaymentType)
                .IsRequired(true)
                .HasMaxLength(10);

           builder.Property(r => r.CardType)
                .IsRequired(true)
                .HasMaxLength(10);

           builder.Property(r => r.CardNumber)
                .IsRequired(true)
                .HasMaxLength(50);

           builder.Property(r => r.CardExp)
                .IsRequired(true)
                .HasMaxLength(50);

           builder.Property(r => r.CardCvc)
                .IsRequired(true)
                .HasMaxLength(10);


           builder.Property(r => r.ArrivalTime)
               .IsRequired(true);

           builder.Property(r => r.LeavingTime)
               .IsRequired(true);

           builder.Property(r => r.CheckIn)
               .IsRequired(true)
               .HasColumnType("bit");

           builder.Property(r => r.BreakFast)
              .IsRequired(true);

           builder.Property(r => r.Lunch)
              .IsRequired(true);

           builder.Property(r => r.Dinner)
              .IsRequired(true);

           builder.Property(r => r.Cleaning)
              .IsRequired(true)
              .HasColumnType("bit");

           builder.Property(r => r.Towel)
              .IsRequired(true)
              .HasColumnType("bit");

           builder.Property(r => r.Ssurprise)
              .IsRequired(true)
              .HasColumnType("bit");

           builder.Property(r => r.SupplyStatus)
              .IsRequired(true)
              .HasColumnType("bit");


           builder.Property(r => r.FoodBill)
            .IsRequired(true);
        }
    }
}
