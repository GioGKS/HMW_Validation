using System;
using System.Linq;

namespace HMW_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Methods excercise1 = new Methods();
            //Reverse And case
            Console.WriteLine("__________REVERSE AND CASE__________\n");
            string str1 = "happy birthday";
            string str2 = "MANY THANKS MOSHE";
            string str3 = "sPoNtAnEoUs";

            Methods.ReverseTheCase(str1);
            Methods.ReverseTheCase(str2);
            Methods.ReverseTheCase(str3);

            //Reverse and Not
            Console.WriteLine("\n__________REVERSE AND NOT__________\n");
            excercise1.ReverseAndNot();

            //PowerRanger
            excercise1.PowerRanger();

        }
    }
}

