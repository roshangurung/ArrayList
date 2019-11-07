using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayL
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 2, 4, 5, 7, 8 };
            Console.WriteLine(numbers.Length);


            var index = Array.IndexOf(numbers, 5);
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
