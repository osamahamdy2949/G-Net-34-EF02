using EFCoreAssignmet02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Configurations
{
    internal class AttendeeConfig : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.ToTable("Attendees").Ignore(a => a.HomeAddress).HasKey(a => a.AttendeeId);

            builder.Property(a => a.FullName).HasColumnType("varchar")
                  .HasMaxLength(100)
                  .HasColumnName("AttendeeName");

            builder.Property(a => a.Email).HasMaxLength(200);

            builder.HasOne<Badge>(b => b.Badge)
                  .WithOne(a => a.Attendee)
                  .HasForeignKey<Badge>(b => b.AttendeeId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
