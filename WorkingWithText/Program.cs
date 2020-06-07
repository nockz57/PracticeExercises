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
            string numbers = Console.ReadLine();

            //Exercise 01
            //Console.WriteLine(TextExercise01.ConsecutiveNumbers(name));

            //Exercise 02
            Console.WriteLine(TextExercise02.Duplicate(numbers));

        }
    }
}
