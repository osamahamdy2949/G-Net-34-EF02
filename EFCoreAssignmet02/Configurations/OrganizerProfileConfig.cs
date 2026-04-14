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
    internal class OrganizerProfileConfig : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.ToTable("OrganizerProfiles").HasKey(op => op.ProfileId);
        }
    }
}
