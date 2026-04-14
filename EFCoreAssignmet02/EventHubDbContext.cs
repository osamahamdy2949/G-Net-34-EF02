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

        DbSet<Organizer> Organizers {  get; set; }
        DbSet<OrganizerProfile> OrganizerProfiles {  get; set; }
        DbSet<Event> Events {  get; set; }
        DbSet<Attendee> Attendees {  get; set; }
        DbSet<Badge> Badges {  get; set; }
    }
}
