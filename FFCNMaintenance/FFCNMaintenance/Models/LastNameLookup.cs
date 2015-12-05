using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCNMaintenance.Models
{
    public class LastNameLookup
    {
        public int caregiverId { get; set; }
        public string LastNameFirstName { get; set; }

        public LastNameLookup(int cg, string lf)  
        {
            this.caregiverId = cg;
            this.LastNameFirstName = lf;
        }
    }

    public class FirstNameLookup
    {
        public int caregiverId { get; set; }
        public string FirstNameLastName { get; set; }

        public FirstNameLookup(int cg, string fl)  
        {
            this.caregiverId = cg;
            this.FirstNameLastName = fl;
        }
    }


    public class PhoneNumberLookup
    {
        public int caregiverId { get; set; }
        public string PhoneNumber { get; set; }

        public PhoneNumberLookup(int cg, string pn)  
        {
            this.caregiverId = cg;
            this.PhoneNumber = pn;
        }
    }
}