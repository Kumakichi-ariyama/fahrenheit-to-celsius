using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit-to-celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal fahrenheit = Convert.ToDecimal(input);

            decimal celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine(celsius);

            Console.ReadKey();
        }
    }
}