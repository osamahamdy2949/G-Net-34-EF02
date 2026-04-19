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
            builder.HasOne(b => b.Badge)
                   .WithOne(a => a.Attendee)
                   .HasForeignKey<Badge>(b => b.AttendeeId)
                   .IsRequired();

            builder.OwnsOne(a => a.HomeAddress);

            //builder.HasMany(e => e.Events)
            //       .WithMany(a => a.Attendees)
            //       .UsingEntity(jt =>
            //       {
            //           jt.ToTable("Registrations")
            //             .Property<DateTime>("CraetedAt").HasDefaultValueSql("GETDATE()");

            //       });
        }
    }
}
