using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------");
                Console.WriteLine("Calculator program");
                Console.WriteLine("------------");

                Console.WriteLine("Enter a number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("+ : Addition");
                Console.WriteLine("- : Subtraction");
                Console.WriteLine("* : Mulitplication");
                Console.WriteLine("/ : Division");

                switch (Console.ReadLine())
                {

                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
                Console.WriteLine("Do you want to continue? Y/N");
            } while(Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye");




            Console.ReadKey();




            


        }
    }
}
