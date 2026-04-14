using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmet02.Models
{
    //[Table("Events")]
    internal class Event
    {
        #region DataAnnotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int EventId { get; set; }
        //public string Title { get; set; } = default!;
        //public string Description { get; set; } = default!;
        //public DateTime StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        //public int MaxAttendees{ get; set; } 
        #endregion

        public int EventId { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
    }
}
