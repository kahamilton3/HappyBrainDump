using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBrainDump.Models
{
    public class UserInterest
    {

        public  string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int InterestId { get; set; }
        public Interest Interest { get; set; }

        public UserInterest()
        {
        }

    }
}
