using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    public class TextExercise02
    {
        /*
         2- Write a program and ask the user to enter a few numbers separated by a hyphen.
         If the user simply presses Enter, without supplying an input, exit immediately; 
         otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
         */

        public static string Duplicate(string numbers)
        {
            var results = new List<string>();
            var index = numbers.Split('-');
            var final = "";

            if (string.IsNullOrWhiteSpace(numbers))
            {
                return "";
            }

            foreach (var number in index)
            {
                results.Add(number);
            }

            if (results.Count != results.Distinct().Count())
            {
                final = "Duplicate";
                return final;
            }

            return final;
        }
    }
}
