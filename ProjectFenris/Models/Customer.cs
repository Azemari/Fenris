using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFenris.Models
{
    public class Customer
    {
        //User's Unique Id 
        public Guid Id { get; set; }

        //FirstName + LastName
        public string Username { get; set; }

        //Default = Free
        public MembershipTypes MembershipType { get; set; }
    }

    public enum MembershipTypes
    {
        Free,
        Premium
    }
}
