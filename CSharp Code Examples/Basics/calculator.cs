using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class   SimpleCalculator
    {
        //Authors: Lorna Foster
        
        public static void run()
        {
            
         // Simple calculator functionality
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // For a new line after the operator input

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator.run();
        }
    }
}