using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Lorna Foster

namespace CSharp_Code_Examples
{ // Temperature changer
    class TemperatureConverter
    {
        // Converts Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Converts Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static void run()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.Write("Choose an option (1 or 2): ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = CelsiusToFahrenheit(celsius);
                    Console.WriteLine($"{celsius}°C is {fahrenheit}°F");
                    break;
                case 2:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine($"{fahrenheit}°F is {celsius}°C");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
