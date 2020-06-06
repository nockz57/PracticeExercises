using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter few numbers separated by a hyphen eg (1-2-3-4)");
            string name = Console.ReadLine();
            Console.WriteLine(TextExercise01.ConsecutiveNumbers(name));

        }
    }
}
