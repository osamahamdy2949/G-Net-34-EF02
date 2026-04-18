using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    internal class Organizer
    {        
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        public OrganizerProfile? Profile { get; set; }
    }
}
