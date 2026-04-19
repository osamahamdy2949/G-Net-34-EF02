using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    internal class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        //public string Street { get; set; } = default!;
        //public string City { get; set; } = default!;
        //public string Country { get; set; } = default!;
        //public string PostalCode { get; set; } = default!;
        public Address HomeAddress { get; set; }
        public Badge? Badge { get; set; }

        public ICollection<Registration> Events { get; set; } = new HashSet<Registration>();
    }
}
