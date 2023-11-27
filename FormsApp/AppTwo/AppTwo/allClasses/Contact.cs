using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTwo.allClasses
{
    internal class Contact
    {
        public int ContactId { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public string ContactCountry { get; set; }

        public string ContactPhone { get; set; }

        public static string ConnectionStrings = ConfigurationManager.ConnectionStrings[""].ConnectionString;
    }
}
