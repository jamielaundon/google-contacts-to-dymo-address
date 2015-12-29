using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace google_contacts_to_dymo_address
{
    public class DymoName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FileAs { get; set; }

        public DymoName(string firstName, string lastName, string fullName)
        {
            FirstName = firstName;
            LastName = lastName;
            FileAs = fullName;
        }
        public DymoName()
        {

        }
    }
}
