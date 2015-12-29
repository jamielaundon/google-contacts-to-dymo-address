using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace google_contacts_to_dymo_address
{
    [Serializable]
    [XmlRoot(ElementName = "AddressBook")]
    public class DymoAddressBook
    {
        // List of AddressEntry
        [XmlElement(ElementName = "AddressEntry")]
        public List<DymoAddressEntry> AddressBook { get; set; }

        //Rest of required attributes: Version="8.0" DefaultPermutation="true" Format="Native">
        [XmlAttribute(AttributeName = "Version")]
        public string Version = "8.0";

        [XmlAttribute(AttributeName = "DefaultPermutation")]
        public string DefaultPermutation = "true";

        [XmlAttribute(AttributeName = "Format")]
        public string Format = "Native";

        public DymoAddressBook()
        {
            AddressBook = new List<DymoAddressEntry>();
        }
    }
}
