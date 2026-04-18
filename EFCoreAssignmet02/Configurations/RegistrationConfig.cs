using EFCoreAssignmet02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Configurations
{
    internal class RegistrationConfig : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => new { r.EventId, r.AttendeeId });

            builder.Property<DateTime>("FirstCreationAt")
                   .HasDefaultValueSql("GETDATE()")
                   .ValueGeneratedOnAdd();
           
            builder.Property<DateTime>("LastUpdateAt")
                   .HasDefaultValueSql("GETDATE()")
                   .ValueGeneratedOnUpdate();

        }
    }
}
