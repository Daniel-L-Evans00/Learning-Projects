using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Advanced_Learning
{
    class Program
    {
        //Constants are imnutable valuse which are known
        //at compile time and do not change the life of the program
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string bDay = "02,23,2000";


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

            myString = "15";
            string mySecoundString = "13";
            // parse will force a conversion while TryParse will return a bool value
            num1 = Int32.Parse(myString);
            num2 = Int32.Parse(mySecoundString);
            int resultInt = num1 + num2;
            string result = myString + mySecoundString;
            Console.WriteLine(resultInt);
            //"Trim" removes all WhiteSpace  

            //data types
            byte myByte = 25; Console.WriteLine(myByte);//range of 0 to 255
            sbyte mySbyte = -15; Console.WriteLine(mySbyte);//range of -127 to 128
            int myInt2 = -12318925; Console.WriteLine(myInt2); //range of -2,147,483,648 to 2,147,483,647
            uint myUint = 123091; Console.WriteLine(myUint); //range of 0 to 4,294,967,295;
            short myShort = -32768; Console.WriteLine(myShort); //range of -32,768 to 32,767
            ushort myUshort = 49927; Console.WriteLine(myUshort); //range of 0 to 65535
            float myFloat2 = -31.1289f; Console.WriteLine(myFloat2);//range of -3.402823e38 to 3.402823e38
            double myDouble2 = -12.1231250; Console.WriteLine(myDouble2);//range of -1.79769313486232e308 to 1.79769313486232e308
            char myChar = 'D'; Console.WriteLine(myChar);//Unicode symbols used in text
            bool myBool = true; Console.WriteLine(myBool);//True or false
            string myString2 = "I Control Text"; Console.WriteLine(myString2);//A sequence of characters
            string numText = "15";
            int myNumFromText = int.Parse(numText); Console.WriteLine(myNumFromText);// Passing a numeric value from a String to an Int

            Console.WriteLine("My birth day will always be: {0}", bDay);

            WriteSomething();
            WriteSomethingSpecific("Method2");
            Console.WriteLine(Add(myInt, myInt2));
            Console.WriteLine(Multiply(25,5));
            Console.WriteLine(Subtract(100,10));

            Console.WriteLine("Write something");
            string input= Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine("please input a number");
            input = Console.ReadLine();
            num1 = int.Parse (input);
            Console.WriteLine("Please input another number");
            input = Console.ReadLine();
            num2 = int.Parse(input);
            Console.WriteLine(Add(num1,num2));

            Console.WriteLine("please enter a number");
            input = Console.ReadLine();
            try
            {
                num1 = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception. please enter a number");
                
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
            num1 = 5;
            num2 = 0;
            try
            {
                sum = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("error");
            }
            //operators 
            num2 = 3;
            num3 = 0;
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3);
            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}",!isSunny);
            //increment operators 
            num = 0;
            num++;
            Console.WriteLine("num is {0}",num);
            Console.WriteLine("num is {0}", num++);//plus after makes it happen after code
            Console.WriteLine("num is {0}", ++num); // plus before makes it happen first
            //decrement operator
            Console.WriteLine("num is {0}",num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", --num);

            sum = num1 + num2;
            Console.WriteLine("sum of {0} + {1} is {2}",num1,num2,sum);
            sum = num1 - num2;
            Console.WriteLine("sum of {0} - {1} is {2}", num1, num2, sum);
            sum = num1 / num2;
            Console.WriteLine("sum of {0} / {1} is {2}", num1, num2, sum);
            sum = num1 * num2;
            Console.WriteLine("sum of {0} X {1} is {2}", num1, num2, sum);
            sum = num1 % num2;
            Console.WriteLine("sum of {0} % {1} is {2}", num1, num2, sum);
            // relational and type operators 
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("is num1 less than num2? {0}",isLower);
            isLower = num1 > num2;
            Console.WriteLine("is num1 greater than num2? {0}",isLower);
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("is num1 equal too num2? {0}",isEqual);
            isEqual = num1 != num2;
            Console.WriteLine("is num1 not rqual too num2? {0}",isEqual);
            //conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}",isLowerAndSunny);
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);



            Console.ReadKey(); //takes a single input of a string type
        }
        //access modifier, (Static), return type, method name (parameter1, parameter2)
        public static void WriteSomething ()
        {
            Console.WriteLine("Method");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        public static int Add(int par1,int par2)
        {
            Console.WriteLine("The sum of {0} + {1} is:",par1,par2);
            return par1 + par2;
        }
        public static int Multiply(int num1,int num2)
        {
            Console.WriteLine("The sum of {0} X {1} is:", num1, num2);
            return num1 * num2;
        }
        public static int Subtract(int num1,int num2)
        {
            Console.WriteLine("The sum of {0} / {1} is:", num1, num2);
            return num1 / num2;
        }
    }
}
