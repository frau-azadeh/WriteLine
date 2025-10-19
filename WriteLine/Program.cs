using System;

namespace WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 6;
            int c = a + b;
            c = a * b;
            //this is a comment
            Console.WriteLine("hello");
            Console.WriteLine("My name");
            Console.WriteLine(c);
            //convert int to string
            int sum = 56;
            string total = Convert.ToString(sum);
            Console.WriteLine(total);
            //convert string to int
            string number1 = "5";
            string number2 = "6";

            string number = number1 + number2;
            Console.WriteLine(number);
            int numberTotal = Convert.ToInt32(number);
            numberTotal ++;
            Console.WriteLine(numberTotal);

            //get to number and sum
            Console.WriteLine("Please Enter your first number:");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter your second number:");
            string secondNumber = Console.ReadLine();

            int first = Convert.ToInt32(firstNumber);
            int second = Convert.ToInt32(secondNumber);

            int sumtotal = first + second;
            Console.WriteLine("total is:"+sumtotal);

            //handler error with try catch
            int tonumber12 = 0;
            int tonumber21 = 0;

            try
            {
                Console.WriteLine("please enter your number:");
                string number12 = Console.ReadLine();
                Console.WriteLine("please enter your second number:");
                string number21 = Console.ReadLine();

                tonumber12 = Convert.ToInt32(number12);
                tonumber21 = Convert.ToInt32(number21);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you must enter number!");
                Console.ResetColor();
            }

            int total12 = tonumber12 + tonumber21;
            Console.WriteLine("sum is: " + total12);
         



            Console.ReadKey();

        }
    }
}
