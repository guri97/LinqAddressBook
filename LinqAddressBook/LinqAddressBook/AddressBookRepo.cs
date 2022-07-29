using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_LinqAddressBook
{

    public class AddressBookRepo
    {
        public static void RetriveBasedOnCity(List<AddressBookInformation> list)
        {
            Console.WriteLine("\nretriving the city and state");
            var res1 = (from p in list where p.City.Equals("Bengaluru") && (p.State.Equals("Karnataka")) select p).ToList();
            Program.RetriveAllData(res1);
        }
    }
}