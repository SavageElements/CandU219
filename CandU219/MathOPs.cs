using System;
using System.Collections.Generic;
using System.Text;

namespace CandU219
{
    class MathOPs
    {

        public int Num1 = 7;

        public int result;
        public static void methodONE(int Num1, int Num2)
        {
            int X = Num1;
            int Y = Num2;
            int result = X + Y;

            Console.WriteLine("Seven plus the number(s) you entered = " + result);
        }


        public static void  methodONE(int Num1, int Num2, params int[] restOfNumbers)

        {
            int X = Num1;
            int Y = Num2;
            int result = X + Y;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }

                Console.WriteLine("Seven plus the number(s) you entered = " + result);
            }
        }

        public static void methodONE(int Num1, int Num2, IEnumerable<int> restOfNumbers)

        {
            int X = Num1;
            int Y = Num2;
            int result = X + Y;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }

                Console.WriteLine("Seven plus the number(s) you entered = " + result);
            }
        }
    }
}
