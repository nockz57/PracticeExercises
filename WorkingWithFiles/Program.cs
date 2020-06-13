using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing 1 2, 1 2");

            //use full file path (e.g c:\users\............)
            var path = @"C:\Users\mphet\source\home\PracticeExercises\DestinationFiles\Lorem.txt";
            File.Copy(@"C:\Users\mphet\source\home\PracticeExercises\SourceFiles\Lorem.txt", path, true);

            if (File.Exists(path))
            {
                Console.WriteLine("The file exist");
            }

            var builder = new StringBuilder();
            builder.Append('-', 115);
            Console.WriteLine(builder);
            Console.WriteLine(File.ReadAllText(path));
            Console.ReadLine();

        }
    }
}
