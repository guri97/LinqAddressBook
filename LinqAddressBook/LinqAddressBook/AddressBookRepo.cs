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
        public static void GetCountByCity(List<AddressBookInformation> list)
        {
            var countData = list.AsEnumerable().GroupBy(city => city.City).
                Select(city => new
                {
                    Cityties = city.Key,
                    cityCount = city.Count()
                });
            foreach (var contactlist in countData)
            {
                Console.WriteLine("City =" + contactlist.Cityties + " --> " + " City_Count =" + contactlist.cityCount);
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
        public static void RetriveBysortingAlphabetically(List<AddressBookInformation> list)
        {
            try
            {
                Console.WriteLine("\nSorted Order");
                //here we are using method syntax
                //here we are retriving the product review based on the higest rating for that we are sortin gthe list in desending oredr
                List<AddressBookInformation> sortedList = (from contacts in list orderby contacts.FirstName ascending select contacts).ToList();
                Program.RetriveAllData(sortedList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void RetirveNameAndType(List<AddressBookInformation> list)
        {
            try
            {
                var countData = list.AsEnumerable().GroupBy(BookType => BookType.AddressBookType).
                Select(BookType => new
                {
                    BookType = BookType.Key,
                    //BookTypeCount = BookType.FirstName
                });
                foreach (var contactlist in countData)
                {
                    Console.WriteLine("AddressBook Type =" + contactlist.BookType);
                }
                var NameData = list.AsEnumerable().GroupBy(BookType => BookType.FirstName).
                    Select(BookType => new
                    {
                        BookType = BookType.Key,
                        //BookTypeCount = BookType.FirstName
                    });
                foreach (var contactlist in NameData)
                {
                    Console.WriteLine("FirstName =" + contactlist.BookType);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AddingDataToAddressBookwithsameNameButDiffType(List<AddressBookInformation> list)
        {
            try
            {
                list.Add(new AddressBookInformation() { ID = 1, FirstName = "Gurpreet", LastName = "Singh", Address = "Aberdeen Bazar", City = "Port Blair", State = "Andamans", Zip = "4232", PhoneNumber = "12345", Email = "gsgurpreet766@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Family" });
                list.Add(new AddressBookInformation() { ID = 1, FirstName = "Gurpreet", LastName = "Singh", Address = "Aberdeen Bazar", City = "Port Blair", State = "Andamans", Zip = "4232", PhoneNumber = "12345", Email = "gsgurpreet766@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Friends" });
                Program.RetriveAllData(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
