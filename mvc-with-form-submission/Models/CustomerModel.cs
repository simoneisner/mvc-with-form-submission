using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace mvcwithformsubmission.Models
{
        
    public class CustomerModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set;  }
        [DisplayName("Country Code")]
        public string CountryCode { get; set;  }
        public SelectList CountryList { get; set; }
    }
}
