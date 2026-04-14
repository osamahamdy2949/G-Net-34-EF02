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
    internal class BadgeConfig : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges").HasKey(b => b.Id);
        }
    }
}
