using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main()
        {
            Console.WriteLine("Temperature Conversion Tool Version 1.0");
            Console.Title = "Temperature Conversion Tool";
            Console.WriteLine("Would you like to convert from F)ahrenheit or from C)elsius?");
            string userChoice = Console.ReadLine().ToUpper();
            if (userChoice == "C" || userChoice == "Celsius")
            {
                Console.Write("Enter the temperature in degrees Celsuis: ");
                decimal tempCelsius = Convert.ToDecimal(Console.ReadLine());
                decimal tempFahrenheit = ((tempCelsius * 9 / 5) + 32);
                Console.WriteLine($"{tempCelsius}°C converts to {tempFahrenheit:0.#}°F. ");
            }
            else if (userChoice == "F" || userChoice == "Fahrenheit")
            {
                Console.Write("Enter the temperature in degrees Fahrenheit: ");
                decimal tempF = Convert.ToDecimal(Console.ReadLine());
                decimal tempC = ((tempF - 32) * 5 / 9);
                Console.WriteLine($"{tempF}°F converts to {tempC:0.#}°C. ");
            }
            else
            {
                Console.WriteLine("That was not a valid option. Please run again and select F or C.");
            }
        }    
    }
}
