namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" @@@@ ADDRESS BOOK @@@@");
            AddressBook contacts = new AddressBook();

            Console.WriteLine("Enter First Name: ");
            contacts.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contacts.lastName = Console.ReadLine();

            Console.WriteLine("Enter City Name: ");
            contacts.city = Console.ReadLine();

            Console.WriteLine("Enter State Name: ");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Enter zip Code: ");
            contacts.zipCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            contacts.phoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email ID: ");
            contacts.emailID = Console.ReadLine();
        }
    }
}