using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mytest.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CCnum { get; set; }
  

        //Bill To Address
        public string BilltoAdd { get; set; }
        public string BilltoState { get; set; }
        public string BilltoCity { get; set; }
        public int BilltoZip { get; set; }



        //Ship To Address
        public string ShiptoAdd { get; set; }
        public string ShiptoState { get; set; }
        public string ShiptoCity { get; set; }
        public int ShiptoZip { get; set; }

    




    }
}
