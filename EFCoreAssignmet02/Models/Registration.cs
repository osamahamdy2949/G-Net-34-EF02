using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    internal class Registration
    {
        //Composite PK (AttendeeId,EventId)
        public int AttendeeId { get; set; } //FK 
        public int EventId { get; set; } //Fk
        public Attendee Attendee { get; set; } = default!;
        public Event Event { get; set; } = default!;
        public string? Note { get; set; }
    }
}
