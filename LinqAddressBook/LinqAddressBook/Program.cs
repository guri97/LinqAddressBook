namespace Day33_LinqAddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<AddressBookInformation> list = new List<AddressBookInformation>();
            Console.WriteLine("AddressBook Information");
            Console.WriteLine("1.AddingInfoToList\n2.RetriveAllInfoFromAddressBook");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddingDataToAddressBook(list);
                    Console.WriteLine("data addes sussesFully");
                    break;
                case 2:

                    break;
            }
        }
        public static void RetriveAllData(List<AddressBookInformation> list)
        {
            try
            {
                foreach (AddressBookInformation item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AddingDataToAddressBook(List<AddressBookInformation> list)
        {
            try
            {
                list.Add(new AddressBookInformation() { ID = 1, FirstName = "Gurpreet", LastName = "Singh", Address = "Aberdeen Bazar", City = "Port Blair", State = "Andaman", Zip = "4232", PhoneNumber = "12345", Email = "gsgurpreet766@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Family" });
                list.Add(new AddressBookInformation() { ID = 2, FirstName = "Lokesh", LastName = "Raj", Address = "School Line", City = "Port Blair", State = "Andamans", Zip = "4232", PhoneNumber = "12345", Email = "Kolki@gmail.com", AddressBookName = "AddressBook2", AddressBookType = "Friends" });
                list.Add(new AddressBookInformation() { ID = 3, FirstName = "jagan", LastName = "Rao", Address = "HCR", City = "Hydrabad", State = "Telangana", Zip = "4233", PhoneNumber = "12345", Email = "Jagan@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Professional" });
                list.Add(new AddressBookInformation() { ID = 4, FirstName = "jadesh", LastName = "Kumar", Address = "omr", City = "Mahabalipuram", State = "AndraPradesh", Zip = "4234", PhoneNumber = "12345", Email = "Jagesh@gmail.com", AddressBookName = "AddressBook2", AddressBookType = "Family" });
                list.Add(new AddressBookInformation() { ID = 5, FirstName = "kavari", LastName = "Kumari", Address = "HSG", City = "VijayaWada", State = "Andrapradesh", Zip = "4235", PhoneNumber = "12345", Email = "Kavari@gmail.com", AddressBookName = "AddressBook2", AddressBookType = "Friends" });
                list.Add(new AddressBookInformation() { ID = 6, FirstName = "Sekhar", LastName = "Rao", Address = "DMR", City = "Hydrabad", State = "Telangana", Zip = "4236", PhoneNumber = "12345", Email = "Vikadd@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Professional" });
                list.Add(new AddressBookInformation() { ID = 7, FirstName = "sheela", LastName = "Kumari", Address = "Mount Road", City = "Bengaluru", State = "Karnataka", Zip = "4238", PhoneNumber = "12345", Email = "Sheela@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Family" });
                RetriveAllData(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}