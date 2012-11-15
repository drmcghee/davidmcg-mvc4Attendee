using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davidmcg_mvc4Attendee.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CompanyName { get; set; }
    }

}