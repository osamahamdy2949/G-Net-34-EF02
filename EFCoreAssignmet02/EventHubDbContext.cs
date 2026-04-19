using EFCoreAssignmet02.Configurations;
using EFCoreAssignmet02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02
{
    internal class EventHubDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase = EventHubDb;Trusted_Connection = true;TrustServerCertificate = true");
        }

        #region DbSets
        DbSet<Organizer> Organizers { get; set; }
        DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Attendee> Attendees { get; set; }
        DbSet<Badge> Badges { get; set; }
        DbSet<Registration> Registrations { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FluentApi Configuration (NotSeparate)
            //=> ModelBuilder Return (EntityTypeBuilder) <=

            //modelBuilder.Entity<Organizer>().ToTable("Organizers").HasKey(o => o.OrganizerId);
            //modelBuilder.Entity<Organizer>().Property(o => o.Name)
            //            .HasColumnType("varchar")
            //            .HasMaxLength(100)
            //            .HasColumnName("OrganizerName");

            //Another Way
            //    modelBuilder.Entity<Organizer>(Entity =>
            //    {
            //        Entity.ToTable("Organizers").HasKey((o => o.OrganizerId));

            //        Entity.Property(o => o.Name)
            //              .HasColumnType("varchar")
            //              .HasMaxLength(100)
            //              .HasColumnName("OrganizerName");

            //        Entity.Property(o => o.CompanyName).HasMaxLength(200);

            //        Entity.HasOne<OrganizerProfile>(op => op.OrganizerProfile)
            //              .WithOne(o => o.Organizer)
            //              .HasForeignKey<OrganizerProfile>(op => op.OrganizerId)
            //              .OnDelete(DeleteBehavior.Cascade);
            //    });

            //    modelBuilder.Entity<OrganizerProfile>(Entity =>
            //    {
            //        Entity.ToTable("OrganizerProfiles").HasKey(op => op.ProfileId);
            //    });

            //    modelBuilder.Entity<Event>(Entity =>
            //    {
            //        Entity.ToTable("Events").HasKey(e => e.EventId);
            //    });

            //    modelBuilder.Entity<Attendee>(Entity =>
            //    {
            //        Entity.ToTable("Attendees").Ignore(a=>a.HomeAddress).HasKey(a => a.AttendeeId);

            //        Entity.Property(a => a.FullName).HasColumnType("varchar")
            //              .HasMaxLength(100)
            //              .HasColumnName("AttendeeName");

            //        Entity.Property(a => a.Email).HasMaxLength(200);

            //        Entity.HasOne<Badge>(b => b.Badge)
            //              .WithOne(a => a.Attendee)
            //              .HasForeignKey<Badge>(b => b.AttendeeId)
            //              .OnDelete(DeleteBehavior.Cascade);
            //    });

            //    modelBuilder.Entity<Badge>(Entity =>
            //    {
            //        Entity.ToTable("Badges").HasKey(b => b.Id);
            //    });
            // 
            #endregion

            modelBuilder.ApplyConfiguration(new OrganizerConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new AttendeeConfig());
            modelBuilder.ApplyConfiguration(new RegistrationConfig());
        }
    }
}