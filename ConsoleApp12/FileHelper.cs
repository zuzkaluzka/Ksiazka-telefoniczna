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
        public static bool PhoneExists(Contact contact)
        {
            using StreamReader reader = new StreamReader("dane.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains($"nr_telefonu: {contact.PhoneNumber}"))
                {
                    return true;
                }
            }
            reader.Close();
            return false;
        }
    }
}
