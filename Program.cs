using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Advanced_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            //  Numeric code
            int num1 = 13, num2 = 17,num3, sum=num1+num2;
            double d1 = 3.5, d2 = 1.337,sumD=d1+d2;
            float f1 = 3.5f;
            //Use casting
            //int divDanDI = d1 / num2;
            num3 = 15;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine("The sum of {0} and {1} is:"+ sum ,num1,num2);
            Console.WriteLine("The sum of {0} and {1} is:" + sumD ,d1,d2);
            // String Code
            string myName = "Dan",message = "My name is ";
            Console.WriteLine(message + myName);
            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);
            string lowerCaseMessage = message.ToLower();
            Console.WriteLine(lowerCaseMessage);
            Console.Write("Prints and keeps Cursor on same line.");
            Console.WriteLine("Prints and puts cursor in the next line");
            //ASCII -> American Standard Code For Information Interchange
            //implicit conversion
            int num = 9999999;
            long bigNum = num;
            float myFloat = 13.37f;
            double myDouble = myFloat;
            bool sunIsShining = true;
            int myInt;
            //explicit conversion
            //cast double to int;
            myInt = (int)myDouble; // int can only hold whole numbers. will cut off any decimals
            Console.WriteLine(myInt);

            //type conversion
            string myString = myDouble.ToString(); //will be "13.37"
            string myFloatString = myFloat.ToString();
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);

            Console.ReadKey(); //takes a single input of a string type
        }
    }
}
