using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class FileHelper
    {
        public static void AddToFile(Contact contact)
        {
            using StreamWriter writer = new StreamWriter("dane.txt", append: true);

            writer.WriteLine($"imie: {contact.Name}, nazwisko: {contact.Surname}, nr_telefonu: {contact.PhoneNumber}");
            writer.Close();
        }
    }
}
