using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace google_contacts_to_dymo_address
{
    class GoogleAddressEntry
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }

        public GoogleAddressEntry(string first, string last, string full, string addr)
        {
            firstName = first;
            lastName = last;
            fullName = full;
            address = addr;
        }
    }
}
