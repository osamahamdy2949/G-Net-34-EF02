using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    //[Table("OrganizerProfiles")]
    internal class OrganizerProfile
    {
        #region DataAnnotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ProfileId { get; set; }
        //public string? Biography { get; set; }
        //public string? WebsiteUrl { get; set; }
        //public string? LogoUrl { get; set; }
        //public Organizer Organizer { get; set; } = default!;

        //[ForeignKey(nameof(Organizer))]
        //public int OrganizerId { get; set; } 
        #endregion

        public int ProfileId { get; set; }
        public string? Biography { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public Organizer Organizer { get; set; } = default!;
        public int OrganizerId { get; set; }
    }
}
