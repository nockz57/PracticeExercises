using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    public class TextExercise01
    {
        /*
         1- Write a program and ask the user to enter a few numbers separated by a hyphen.
         Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
         display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Assuming the user provides input in the format that the program expects.
         */
        public static string ConsecutiveNumbers(string numbers)
        {
            List<string> results = new List<string>();
            var index = numbers.Split('-');
            string final = "Consecutive";

            for (int i = 0; i < index.Length; i++)
            {
                results.Add(index[i]);

                //check if we have a previous record
                if (i > 0)
                { 
                    //check for numbers counting down (eg 4-3-2-1) (4 - 3 = 1)
                    if ((Convert.ToInt32(results[i - 1])) > (Convert.ToInt32(results[i])))
                    {
                        if ((Convert.ToInt32(results[i - 1])) - (Convert.ToInt32(results[i])) != 1)
                        {
                            final = "Non-consecutive";
                            return final;
                        }
                    }

                    //check numbers counting up (eg 1-2-3-4) (1 - 2 = -1)
                    else 
                    {
                        if ((Convert.ToInt32(results[i - 1])) - (Convert.ToInt32(results[i])) != -1)
                        {
                            final = "Non-consecutive";
                            return final;
                        }
                    }

                }
            }

            return final;
        }
    }
}
