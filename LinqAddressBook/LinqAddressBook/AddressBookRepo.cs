using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Day33_LinqAddressBook
{

    public class AddressBookRepo
    {
        public static void RetriveBasedOnCity(List<AddressBookInformation> list)
        {
            try
            {
                Console.WriteLine("\nretriving the city and state");
                var res1 = (from p in list where p.City.Equals("Bengaluru") && (p.State.Equals("Karnataka")) select p).ToList();
                Program.RetriveAllData(res1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateData(List<AddressBookInformation> list)
        {
            try
            {
                (from p in list where p.ID == 3 select p).ToList().ForEach(x => x.City = "Kolkata");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteData(List<AddressBookInformation> list)
        {
            try
            {
                list.RemoveAll(x => x.City == "hubli");
                Console.WriteLine("deleted succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void GetCountByAddressBookType(List<AddressBookInformation> list)
        {
            var countData = list.AsEnumerable().GroupBy(BookType => BookType.AddressBookType).
                Select(BookType => new
                {
                    BookType = BookType.Key,
                    BookTypeCount = BookType.Count()
                });
            foreach (var contactlist in countData)
            {
                Console.WriteLine("AddressBook Type =" + contactlist.BookType + " --> " + "AddressBook_Count = " + contactlist.BookTypeCount);
            }
        }
    }

}