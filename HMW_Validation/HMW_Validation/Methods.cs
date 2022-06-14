using System;
using System.Collections.Generic;

namespace HMW_Validation
{
	public class Methods
	{
		public Methods()
		{
		}

		public static string ReverseTheCase(string str)
        {
            char[] someChar = str.ToCharArray();
            char[] cUpper = str.ToUpper().ToCharArray();
            char[] cLower = str.ToLower().ToCharArray();

            for (int i = 0; i < someChar.Length; i++)
            {
                if (someChar[i] == cUpper[i])
                {
                    someChar[i] = cLower[i];
                    Console.Write(someChar[i]);
                }
                else
                {
                    someChar[i] = cUpper[i];
                    Console.Write(someChar[i]);
                }
                
                
            }
            Console.WriteLine();
            return str;
        }

        public void ReverseAndNot()
        {
            Console.WriteLine("Please Enter Number that Is More than 9");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num <= 9)
            {
                Console.WriteLine("Not good! Please Enter Number that Is More Than 9:");
                num = int.Parse(Console.ReadLine());
            }

            string str1 = num.ToString();
            string reversedStr = num.ToString();
            reversedStr = Reverse(reversedStr);

            Console.WriteLine(reversedStr + str1);

            static string Reverse(string str)
            {
                List<char> reverse = new List<char>();

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse.Add(str[i]);

                }
                string rev = "";
                reverse.ForEach(x => rev += x);


                return rev;
            }

        }

        public void PowerRanger()
        {
            int powNum = 1;

            Console.WriteLine("Please Enter First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Powe Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<double> dbList = new List<double>();
            double db = 0;

            while (db <= b)
            {
                db = Math.Pow(powNum, n);
                if(db <= b)
                {
                    dbList.Add(db);
                    powNum++;
                }
            }
            Console.WriteLine($"Number Of Values We got: {dbList.Count}");

        }

    }

}


