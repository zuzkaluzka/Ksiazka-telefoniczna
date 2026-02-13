using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Menu
    {
        public static void Options()
        {
            Console.WriteLine("1 - Dodaj nowy numer");
            Console.WriteLine("2 - Usuń numer");
            Console.WriteLine("3 - Zakończ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Contact contact = ContactCollector.ContactDetails();
                UpdateInfo.Updating(contact);
            }
            else if(option == 2)
            {
                DeleteNumber.Delete();
            }
            else if (option == 3)
            {
                Environment.Exit(0);
            }
        }
    }
}
