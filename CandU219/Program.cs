using System;
using System.Collections.Generic;

namespace CandU219
{
    class Program
    { 
        static void Main(string[] args)
        {
            int Num1 = 7;

            List<int> restOfNumbers = new List<int>();

            bool loopOne = true;


                Console.WriteLine("Please enter a number");
                int Num2 = Convert.ToInt16(Console.ReadLine());



            while (loopOne == true)
            {
                Console.WriteLine("If you would like to enter another number please do so now. \n" +
                    "If not, please press 'Enter'");

                string nextNum =Console.ReadLine();

                if (string.IsNullOrEmpty(nextNum))
                    {
                    MathOPs.methodONE(Num1, Num2, restOfNumbers);
                    Console.ReadLine();
                    loopOne = false;
                    break;
                }
                else
                {
                    int newInput = Convert.ToInt16(nextNum);
                    restOfNumbers.Add(newInput);
                }

            }
        }
    }
}
