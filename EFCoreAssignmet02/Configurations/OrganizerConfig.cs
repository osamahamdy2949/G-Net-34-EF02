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
    internal class OrganizerConfig : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.ToTable("Organizers").HasKey((o => o.OrganizerId));

            builder.Property(o => o.Name)
                  .HasColumnType("varchar")
                  .HasMaxLength(100)
                  .HasColumnName("OrganizerName");

            builder.Property(o => o.CompanyName).HasMaxLength(200);

            builder.HasOne<OrganizerProfile>(op => op.OrganizerProfile)
                  .WithOne(o => o.Organizer)
                  .HasForeignKey<OrganizerProfile>(op => op.OrganizerId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
