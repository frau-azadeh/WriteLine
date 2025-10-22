using System;

namespace WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {

            //int a = 5;
            //int b = 6;
            //int c = a + b;
            //c = a * b;
            //this is a comment
            //Console.WriteLine("hello");
            //Console.WriteLine("My name");
            //Console.WriteLine(c);
            //convert int to string
            //int sum = 56;
            //string total = Convert.ToString(sum);
            //Console.WriteLine(total);
            //convert string to int
            //string number1 = "5";
            //string number2 = "6";

            //string number = number1 + number2;
            //Console.WriteLine(number);
            //int numberTotal = Convert.ToInt32(number);
            //numberTotal++;
            //Console.WriteLine(numberTotal);

            //get to number and sum
            //Console.WriteLine("Please Enter your first number:");
            //string firstNumber = Console.ReadLine();
            //Console.WriteLine("Please enter your second number:");
            //string secondNumber = Console.ReadLine();

            //int first = Convert.ToInt32(firstNumber);
            //int second = Convert.ToInt32(secondNumber);

            //int sumtotal = first + second;
            //Console.WriteLine("total is:" + sumtotal);

            //handler error with try catch
            //int tonumber12 = 0;
            //int tonumber21 = 0;

            //try
            //{
            //    Console.WriteLine("please enter your number:");
            //    string number12 = Console.ReadLine();
            //    Console.WriteLine("please enter your second number:");
            //    string number21 = Console.ReadLine();

            //    tonumber12 = Convert.ToInt32(number12);
            //    tonumber21 = Convert.ToInt32(number21);
            //}
            //catch
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("you must enter number!");
            //    Console.ResetColor();
            //}

            //int total12 = tonumber12 + tonumber21;
            //Console.WriteLine("sum is: " + total12);

            //if and else
            //string name = "";
            //string family = "";

            //Console.WriteLine("Please Enter ypur name:");
            //name = Console.ReadLine();
            //name = name.ToLower();

            //Console.WriteLine("Please enter family:");
            //family = Console.ReadLine();
            //family = family.ToLower();

            //if(name == "azadeh" || family =="sharifi")
            //{
            //    Console.WriteLine($"Hello {name} {family}");
            //}
            //else
            //{
            //    Console.WriteLine("please login");
            //}
            // if else example
            //try
            //{
            //    Console.WriteLine("please enter your number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number == 2)
            //    {
            //        Console.WriteLine("you enter even number");
            //    }
            //    if (number == 1)
            //    {
            //        Console.WriteLine("you enter odd number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("you enter number");
            //    }
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("please enter your valid number");
            //}

            //Console.WriteLine("Please enter your number:");

            //try
            //{
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    switch (number % 2)
            //    {
            //        case 0:
            //            Console.WriteLine("you enter even number");
            //            break;

            //        case 1:
            //            Console.WriteLine("you enter odd number");
            //            break;
            //    }
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("please enter number");
            //}

            //for(int i= 0; i < 20; i++)
            //{
            //    Console.WriteLine("the number is " + i);
            //}

            //int[] numbers = { 1, 5, 3, 7 };
            //int number = numbers[3];

            //string[] Names = { "ali", "Hamed", "Hasan" }; 
            //for(int i=0; i<=2; i++)
            //{
            //    Console.WriteLine(Names[i].ToLower());
            //}

            //string[] Names = { "ali", "hasan", "hosein" };
            //for(int i=0; i<=2; i++)
            //{
            //    string name = Names[i].ToLower();
            //    string changeName = char.ToUpper(name[0]) + name.Substring(1);
            //    Console.WriteLine(changeName);
            //}

            //int i = 0;
            //while (i <= 20)
            //{
            //    Console.WriteLine("number is: " + i);
            //    i++;
            //}
            //try
            //{
            //    Console.WriteLine("please enter your number: ");
            //    int Number = Convert.ToInt32(Console.ReadLine());
            //    string[] Names = new string[Number];
            //    for(int i=0; i<Number; i++)
            //    {
            //        Console.WriteLine("Please enter name:" + (i + 1));
            //        Names[i] = Console.ReadLine();
            //    }
            //    foreach (string name in Names)

            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("hello " + name);
            //        Console.ResetColor();
            //    }
            //}
            //catch(FormatException)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Oops! please enter number");
            //    Console.ResetColor();
            //}

            //    SayHello();
            //    Console.ReadKey();

            //}
            //static void SayHello()
            //{
            //    Console.WriteLine("hello user");
            //}
            //    int sum = Sum(20, 15);
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine("sum is: " + sum);
            //    Console.ReadLine();
            //}
            //static int Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //    Console.ForegroundColor = ConsoleColor.DarkCyan;
            //    Console.WriteLine(FullName("iman", "rad"));
            //    Console.ResetColor();
            //    Console.ReadLine();
            //}
            //static string FullName(string name, string family)
            //{
            //    return name + " " + family;
            //}

            //    SayHello();
            //    SayHello("Iman");
            //    Console.ReadLine();
            //}
            //static void SayHello()
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //    Console.WriteLine("hi");
            //    Console.ResetColor();
            //}
            //static void SayHello(string name)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //    Console.WriteLine("hello " + name);
            //    Console.ResetColor();
            //}
            //int sum = SumNumber.Sum(5, 6);
            //Console.WriteLine("Sum is: " + sum);
            //Console.ReadKey();

            //string show = Information.fullName("Azadeh" , "sharifi");
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine("information is: " + show);
            //Console.ResetColor();
            //Console.ReadLine();

            //Car car1 = new Car();
            //car1.CarModel = "c300";
            //car1.CarName = "Benz";
            //car1.year = 2020;

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Car Model"+ car1.CarModel +"Car Name" + " " + car1.CarName +"Car year" + " " + car1.year + " ");
            //Console.ResetColor();
            //Console.ReadLine();

            //User user1 = new User("Azadeh", "sharifi", 42);
            //Console.WriteLine($"name: {user1.name} family: {user1.family} age: {user1.age} ");
            //Console.ReadLine();

            //Console.WriteLine("Please enter personal number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //User[] people = new User[number];

            //for(int i = 0; i<number; i++)
            //{
            //    Console.WriteLine($"Please enter user[{(i + 1)}] name:");
            //    String name = Console.ReadLine();

            //    Console.WriteLine($"Please enter user[{(i + 1)}] family:");
            //    string family = Console.ReadLine();

            //    Console.WriteLine($"Please enter user [{(i + 1)}] age: ");
            //    int age =Convert.ToInt32( Console.ReadLine());

            //    User u = new User(name, family, age);
            //    people[i] = u;
            //}
            //foreach(User user in people)
            //{
            //    Console.WriteLine($"Name: {user.name} family: {user.family} age: {user.age}");
            //    Console.ReadLine();
            //}

            //MyFlower flower1 = new MyFlower();
            //flower1.name = "zamfolya";
            //flower1.color = "green";
            //flower1.quantity = "25";
            //flower1.price = "4000";

            //MyFlower.flowerShopName = "poone";
            //MyFlower.address = "tehran";
            //MyFlower.phoneNumber = "09122764435";

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine(flower1.name);
            //Console.WriteLine(flower1.color);
            //Console.WriteLine(flower1.quantity);
            //Console.WriteLine(flower1.price);

            //Console.WriteLine(MyFlower.flowerShopName);
            //Console.WriteLine(MyFlower.address);
            //Console.WriteLine(MyFlower.phoneNumber);

            //Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Parent.Sum(5, 6));
            Console.WriteLine(Parent.Minus(10, 8));
            Console.WriteLine(Child.multiply(6, 8));
            Console.ResetColor();

            Console.ReadKey();


        }
    }

}
