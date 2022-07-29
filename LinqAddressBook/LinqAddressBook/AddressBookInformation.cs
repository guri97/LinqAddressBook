using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_LinqAddressBook
{
    public class AddressBookInformation
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressBookName { get; set; }
        public string AddressBookType { get; set; }
        public override string ToString()//it will print each object values with out doing it manually in main
        {
            return $"Id:{ID}\tFirstName: {FirstName}\tLastName: {LastName}\tAddress: {Address}\tCity:{City} State: {State}\tZip: {Zip}\tPhoneNumber: {PhoneNumber}\tEmail: {Email}\tAddressBookName:{AddressBookName}\tAddressBookType:{AddressBookType} ";
        }
    }
}