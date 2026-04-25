using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore02
{
    [Table("Attendees")]
    internal class Attendee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Address HomeAddress { get; set; }

        public Badge AttendeeBadge { get; set; }
        public int BadgeId { get; set; }

        public ICollection<EventAttendees> EventAttendees { get; set; }
    }
}
