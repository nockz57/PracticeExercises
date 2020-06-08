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

            //Ensure user actually provide values and in the right format
            if (!string.IsNullOrWhiteSpace(timeValue) && index.Length > 1)
            {
                //Convert string numbers to integer
                bool hoursSuccess = int.TryParse(index[0], out int hours);
                bool minutesSuccess = int.TryParse(index[1], out int minutes);                

                //if user entered valid numbers proceed
                if (minutesSuccess && hoursSuccess)
                {
                    //if user entered valid hours between 0 and 24, proceed
                    if (hours >= 0 && hours < 24)
                    {
                        //If user entered valid minutes between 0 and 60, proceed
                        if (minutes >= 0 && minutes <= 59)
                        {
                            //user has provided a valid time, so it's ok.
                            results = "Ok";
                            return results;
                        }
                    }  
                }
            }

            return results;
        }

    }
}
