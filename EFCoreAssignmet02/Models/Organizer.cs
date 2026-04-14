using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    [Table("Organizers")]
    internal class Organizer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizerId { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Name Can't be More Than 100 Char")]
        public string Name { get; set; } = default!;

        [MaxLength(200)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        public OrganizerProfile OrganizerProfile { get; set; } = default!;
    }
}
