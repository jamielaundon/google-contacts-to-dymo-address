using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace google_contacts_to_dymo_address
{
    class GoogleAddressBook
    {
        public List<GoogleAddressEntry> addresses { get; set; }

        public GoogleAddressBook(string csvFilenameToParse)
        {
            addresses = new List<GoogleAddressEntry>();
            parseCSV(csvFilenameToParse);
        }

        private void parseCSV(string csvFilenameToParse)
        {
            using (StreamReader reader = File.OpenText(csvFilenameToParse))
            {
                var csv = new CsvReader(reader);
                while (csv.Read())
                {
                    var fullName = csv.GetField<string>("Name");
                    var firstName = csv.GetField<string>("Given Name");
                    var lastName = csv.GetField<string>("Family Name");
                    var address = csv.GetField<string>("Address 1 - Formatted");

                    GoogleAddressEntry e = new GoogleAddressEntry(firstName, lastName, fullName, address);
                    addresses.Add(e);
                }
            }
        }
    }
}
