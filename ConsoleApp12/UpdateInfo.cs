using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class UpdateInfo
    {
        public static void Updating(Contact contact)
        {
            if(PhoneExists.CheckPhone(contact))
            {
                Console.WriteLine("Numer telefonu juz istnieje, czy chcesz go nadpisać? (t/n)");
                string answer = Console.ReadLine();

                if (answer == "t")
                {
                    PhoneExists.UpdateContact(contact);
                    Console.WriteLine("Numer został zaktualizowany");
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Numer nie został zapisany, bo kontakt już istnieje");
                }
            }
            else
            {
                FileHelper.AddToFile(contact);
                Console.WriteLine("Dodano");
            }

        }
    }
}
