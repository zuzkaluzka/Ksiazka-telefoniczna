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

            writer.WriteLine($"{contact.PhoneNumber}-{contact.Name} {contact.Surname}");
            writer.Close();  
        }
       
    }
}
