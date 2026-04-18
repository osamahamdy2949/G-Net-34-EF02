using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    internal class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; } = default!;
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; } = default!;
        public Attendee Attendee { get; set; } = default!; //Nav Prop
        public int AttendeeId { get; set; } //FK

    }
}
