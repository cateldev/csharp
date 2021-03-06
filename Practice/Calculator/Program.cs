using System;

namespace ExerciceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string end = Console.ReadLine();
            string start = Console.ReadLine();
            Console.WriteLine("Calculator TI-82");
            Console.Write("Type start to begin");         
            
            if (start == "start")
            {
                while (end == ("end"))
                {
                    Console.WriteLine("Type the first number");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Type the operator");
                    string symbol = Console.ReadLine();

                    Console.WriteLine("Type the second number");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (symbol)
                    {
                        case "+":
                            Console.WriteLine($"Result: {Plus(num1, num2)}");
                            break;
                        case "-":
                            Console.WriteLine($"Result: {Minus(num1, num2)}");
                            break;
                        case "*":
                            Console.WriteLine($"Result: {Multi(num1, num2)}");
                            break;
                        case "/":
                            Console.WriteLine($"Result: {Divide(num1, num2)}");
                            break;
                        default:
                            Console.WriteLine("Invalid operator");
                            break;
                    }
                    Console.WriteLine("Type end to finish application");
                    end = Console.ReadLine();            
                }
            }
            else
            {
                Console.WriteLine("Closing the application");
            }
        }
        public static string Plus(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string Minus(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string Multi(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string Divide(int num1, int num2)
        {
            if (valuezero(num2))
            {
                return "It is not possible to do that";
            }
            return (num1 / num2).ToString();

            bool valuezero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }   
        }
       
    }
}


