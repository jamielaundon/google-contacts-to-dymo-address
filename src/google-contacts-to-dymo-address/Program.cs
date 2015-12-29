using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace google_contacts_to_dymo_address
{
    class Program
    {
        static string inputFilename = "google.csv";
        static string outputFilename = "dymo.abx";

        static void Main(string[] args)
        {
            Console.WriteLine("Google Contacts to Dymo Address");
            Console.WriteLine("-------------------------------\r\n");

            GoogleAddressBook google = new GoogleAddressBook(inputFilename);
            DymoAddressBook dymo = new DymoAddressBook();

            foreach (GoogleAddressEntry contact in google.addresses)
            {
                DymoAddressEntry entry = new DymoAddressEntry(contact.firstName, contact.lastName, contact.fullName, contact.address);
                dymo.AddressBook.Add(entry);
            }

            exportDymoAddressBook(dymo, outputFilename);
            Thread.Sleep(3000);

        }

        private static void exportDymoAddressBook(DymoAddressBook addressBook, string outputFilename)
        {
            XmlSerializer writer = new XmlSerializer((typeof(DymoAddressBook)));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            //Create an empty namespace
            ns.Add("", "");
            System.IO.StreamWriter file = new System.IO.StreamWriter(outputFilename);
            writer.Serialize(file, addressBook,ns);
            file.Close();
            Console.WriteLine("Exported {0}", outputFilename);
        }
    }
}
