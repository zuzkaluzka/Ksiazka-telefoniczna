using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class DeleteNumber
    {
        public static void Delete()
        {
            Console.WriteLine("Podaj numer który chcesz usunąć: ");
            string number = Console.ReadLine();
            string line;
            string foundLine = null;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader("dane.txt");
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains($"{number}"))
                {
                    foundLine = line;
                }
                else
                {
                    lines.Add(line);
                }
            }
            reader.Close();

            string[] parts = foundLine.Split('-');

            string phoneNumber = parts[0];
            string fullName = parts[1];

            Console.WriteLine($"{number} - {fullName}");
            Console.WriteLine("Czy napewno chcesz usunąć ten kontakt? (t/n)");
            string answer = Console.ReadLine();

            if (answer == "t")
            {
                using StreamWriter writer = new StreamWriter("dane.txt", append: false);
                foreach (var l in lines)
                {
                    writer.WriteLine(l);
                }
                writer.Close();


                Console.WriteLine("Numer usunięty");
            }
            else
            {
                Console.WriteLine("Anulowano usuwanie");
            }
        }
    }
}
