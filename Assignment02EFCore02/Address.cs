using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore02
{
    [Owned]
    internal class Address
    {
        public string Street { get; set; }
        public string   City   { get; set; }

        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
