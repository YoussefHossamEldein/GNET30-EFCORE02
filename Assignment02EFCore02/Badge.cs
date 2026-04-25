using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore02
{
    internal class Badge
    {
        public int Id { get; set; }

        public DateTime IssueDate { get; set; }
        public BadgeTier Tier { get; set; }

        public Attendee Attendee { get; set; }
    }
    internal enum BadgeTier
    {
        Standard,VIP
    }
}
