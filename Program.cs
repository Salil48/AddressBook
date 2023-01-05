namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    AddressBookSystem.UC5_Multiple.GetCustomer();
                    AddressBookSystem.UC5_Multiple.ListingPeople();
                    break;
                case "2":
                    AddressBookSystem.UC5_Multiple.GetCustomer();
                    AddressBookSystem.UC5_Multiple.Modify();
                    AddressBookSystem.UC5_Multiple.ListingPeople();
                    break;
                case "3":
                    AddressBookSystem.UC5_Multiple.GetCustomer();
                    AddressBookSystem.UC5_Multiple.ListingPeople();
                    break;
                case "4":
                    AddressBookSystem.UC5_Multiple.GetCustomer();
                    AddressBookSystem.UC5_Multiple.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }



        }
    }
}