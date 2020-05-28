using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Practicing_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Some text"; // string puts data into a text format
            int num = 10; // int holds whole numbers values
            double num2 = 10.5; //Double holds int valuse into decimals
            bool isOrdered = true; // Bool is true/False operator
            Console.WriteLine("Please write a word");
            string input = Console.ReadLine(); // get data right from user input
            var anything = 30; // Var detects type
            //CW outputs to screen
            Console.WriteLine(text);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(isOrdered);
            Console.WriteLine(input);
            Console.WriteLine(anything);

            //converting a string to an int
            Console.WriteLine("please pick a number...");
            input = Console.ReadLine();
            int userNum;
            //int.TryParse(USER INPUT, out INT VARIABLE)
            //if user input isnt numerical conversion will fail and output a false bool
            int.TryParse(input, out userNum);

            string[] values = { "able", "ångström", "apple", "Æble", "Windows", "Visual Studio" };
            Array.Sort(values);
            DisplayArray(values);
            string originalCulture = CultureInfo.CurrentCulture.Name;
            Console.WriteLine();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
            Array.Sort(values);
            DisplayArray(values);

            Thread.CurrentThread.CurrentCulture = new CultureInfo(originalCulture);
            Console.WriteLine("hit any key to end....");
            Console.ReadKey();
        }
        static void DisplayArray(string[] values)
        {
            Console.WriteLine("Sorting using the {0} culture:",CultureInfo.CurrentCulture.Name);
            foreach (string value in values)Console.WriteLine("   {0}", value);
            Console.WriteLine();
        }
    }
}
