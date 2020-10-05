using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of C#!!");
            string line;
            line = Console.ReadLine();
            int numarPantof;
            try
            {
                numarPantof = Convert.ToInt32(line);
                Console.WriteLine($"Aveti {numarPantof} numarul la pantof.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
