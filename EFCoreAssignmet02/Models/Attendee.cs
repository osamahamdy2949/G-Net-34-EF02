using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    //[Table("Attendees")]
    internal class Attendee
    {
        #region DataAnnotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int AttendeeId { get; set; }
        //public string FullName { get; set; } = default!;

        //[MaxLength(200)]
        //[EmailAddress]
        //public string Email { get; set; } = default!;
        //public string Street { get; set; } = default!;
        //public string City { get; set; } = default!;
        //public string Country { get; set; } = default!;
        //public string PostalCode { get; set; } = default!;

        //[NotMapped]
        //public string HomeAddress => $"{PostalCode}-{Street}-{City}-{Country}";

        //public Badge? Badge { get; set; } 
        #endregion

        public int AttendeeId { get; set; }
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
        public string HomeAddress => $"{PostalCode}-{Street}-{City}-{Country}";
        public Badge? Badge { get; set; }
    }
}
