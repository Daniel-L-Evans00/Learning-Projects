using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            input = Console.ReadLine();
            int userNum;
            //int.TryParse(USER INPUT, out INT VARIABLE)
            //if user input isnt numerical conversion will fail and output a false bool
            int.TryParse(input, out userNum);



        }
    }
}
