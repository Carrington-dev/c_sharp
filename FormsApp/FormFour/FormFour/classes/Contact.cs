using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFour.classes
{
    internal class Contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ContactID { get; set; }

        public string ContactCountry { get; set; }

        public string ContactPhone { get; set; }

        public static string ContactConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

    }
}
