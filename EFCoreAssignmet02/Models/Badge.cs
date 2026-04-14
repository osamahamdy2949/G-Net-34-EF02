using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    [Table("Badges")]
    internal class Badge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string BadgeNumber { get; set; } = default!;
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; } = default!;

        public Attendee Attendee { get; set; } = default!;

        [ForeignKey(nameof(Attendee))]
        public int AttendeeId { get; set; }
    }
}
