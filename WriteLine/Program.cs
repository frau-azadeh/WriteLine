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

            Console.ReadKey();



        }
    }
}
