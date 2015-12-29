using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace google_contacts_to_dymo_address
{
    
    public class DymoAddressEntry
    {
        public string AddressData { get; set; }
        public DymoName Name { get; set; }

        public DymoAddressEntry(string firstName, string lastName, string fullName, string address)
        {
            StringBuilder add = new StringBuilder();    // Add the name to the top of the address
            add.AppendLine(fullName);
            add.AppendLine(address);
            AddressData = add.ToString();
            Name = new DymoName(firstName, lastName, fullName);
        }

        public DymoAddressEntry()
        {

        }
    }
}
