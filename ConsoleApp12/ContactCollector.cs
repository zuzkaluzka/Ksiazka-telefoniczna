using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class ContactCollector
    {
        public static Contact ContactDetails()
        {
            Console.WriteLine("Podaj imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj nr telefonu: ");
            int phone_number = int.Parse(Console.ReadLine());

            return new Contact
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phone_number
            };
        }
    }
}
