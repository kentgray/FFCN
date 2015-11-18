using FFCNMaintenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCNMaintenance.ViewModels
{
    public class SelectCaregiverViewModel
    {
        public List<LastNameLookup> LastNameList { get; set; }
        public List<FirstNameLookup> FirstNameList { get; set; }
        public List<PhoneNumberLookup> PhoneNumberList { get; set; }
    }
}