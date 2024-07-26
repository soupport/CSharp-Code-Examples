using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Lorna Foster

namespace CSharp_Code_Examples
{
    class UnitConverter //Converting units of measurement
    {
        // Converts meters to kilometers
        public static double MetersToKilometers(double meters)
        {
            return meters / 1000;
        }

        // Converts kilometers to meters
        public static double KilometersToMeters(double kilometers)
        {
            return kilometers * 1000;
        }

        // Converts meters to miles
        public static double MetersToMiles(double meters)
        {
            return meters / 1609.34;
        }

        // Converts miles to meters
        public static double MilesToMeters(double miles)
        {
            return miles * 1609.34;
        }

        // Converts feet to meters
        public static double FeetToMeters(double feet)
        {
            return feet * 0.3048;
        }

        // Converts meters to feet
        public static double MetersToFeet(double meters)
        {
            return meters / 0.3048;
        }

        public static void run()
        {
            Console.WriteLine("Unit Converter");
            Console.WriteLine("1. Converting Meters to Kilometers");
            Console.WriteLine("2. Converting Kilometers to Meters");
            Console.WriteLine("3. Converting Meters to Miles");
            Console.WriteLine("4. Converting Miles to Meters");
            Console.WriteLine("5. Converting Feet to Meters");
            Console.WriteLine("6. Converting Meters to Feet");
            Console.Write("Please choose an option (1 to 6): ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter value in meters: ");
                    double meters = Convert.ToDouble(Console.ReadLine());
                    double kilometers = MetersToKilometers(meters);
                    Console.WriteLine($"{meters} meters is {kilometers} kilometers");
                    break;
                case 2:
                    Console.Write("Enter value in kilometers: ");
                    kilometers = Convert.ToDouble(Console.ReadLine());
                    meters = KilometersToMeters(kilometers);
                    Console.WriteLine($"{kilometers} kilometers is {meters} meters");
                    break;
                case 3:
                    Console.Write("Enter value in meters: ");
                    meters = Convert.ToDouble(Console.ReadLine());
                    double miles = MetersToMiles(meters);
                    Console.WriteLine($"{meters} meters is {miles} miles");
                    break;
                case 4:
                    Console.Write("Enter value in miles: ");
                    miles = Convert.ToDouble(Console.ReadLine());
                    meters = MilesToMeters(miles);
                    Console.WriteLine($"{miles} miles is {meters} meters");
                    break;
                case 5:
                    Console.Write("Enter value in feet: ");
                    double feet = Convert.ToDouble(Console.ReadLine());
                    meters = FeetToMeters(feet);
                    Console.WriteLine($"{feet} feet is {meters} meters");
                    break;
                case 6:
                    Console.Write("Enter value in meters: ");
                    meters = Convert.ToDouble(Console.ReadLine());
                    feet = MetersToFeet(meters);
                    Console.WriteLine($"{meters} meters is {feet} feet");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
