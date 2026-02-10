using System.Data;

namespace ConsoleApp12
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = ContactCollector.ContactDetails();

            FileHelper.AddToFile(contact);
        }
    }
}
