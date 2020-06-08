using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    public class TextExercise03
    {
        /*
         3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
         A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
         otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
         */

        public static string TimeValue(string timeValue)
        {

            var index = timeValue.Split(':');
            var results = "Invalid Time";

            if (Convert.ToInt32(index[0]) >= 0 && Convert.ToInt32(index[0]) <= 23)
            {
                if (Convert.ToInt32(index[1]) >= 0 && Convert.ToInt32(index[1]) <= 59)
                {
                    results = "Ok";
                    return results;
                }                
            }

            return results;
        }

    }
}
