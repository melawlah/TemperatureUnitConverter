using System;

namespace UnitConverter
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //prompts user to enter a value
            Console.WriteLine("Please enter the value to be converted");
            var userInput = Console.ReadLine();

            var isInputANumber = isANumber(userInput, out int value);

            //checks if the user entered a number of if the number is greater than 0
            while (!isInputANumber || value < 0)
            {
                Console.WriteLine("Please enter a number with a value greater than 0");
                userInput = Console.ReadLine();
                isInputANumber = isANumber(userInput, out value);
            }

            Console.WriteLine($"{Environment.NewLine}1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Celsius to Kelvin");
            Console.WriteLine("3. Convert Fahrenheit to Celsius");
            Console.WriteLine("4. Convert Fahrenheit to Kelvin");
            Console.WriteLine("5. Convert Kelvin to Celsius");
            Console.WriteLine("6. Convert Kelvin to Fahrenheit");
            Console.WriteLine("7. Exit");

            var optionSelected = Console.ReadLine();

            Conversion conversion = new Conversion(value);
            double convertedValue;

            switch (optionSelected)
            {
                case "1":
                    convertedValue = conversion.ConvertCelsiusToFahrenheit();
                    Console.WriteLine(value +" degree celcius is equal to " + convertedValue + " degree fahrenheit" );
                    break;
                case "2":
                     convertedValue = conversion.ConvertCelsiusToKelvin();
                    Console.WriteLine(value + " degree celsius is equal to " + convertedValue + " kelvin");
                    break;
                case "3":
                    convertedValue = conversion.ConvertFahrenheitToCelsius();
                    Console.WriteLine(value + " degree fahrenheit is equal to " + convertedValue + " degree celsius");
                    break;
                case "4":
                    convertedValue = conversion.ConvertFahrenheitToKelvin();
                    Console.WriteLine(value + " degree fahrenheit is equal to " + convertedValue + " kelvin");
                    break;
                case "5":
                    convertedValue = conversion.ConvertKelvinToCelsius();
                    Console.WriteLine(value + " kelvin is equal to " + convertedValue + " degree celsius");
                    break;
                case "6":
                    convertedValue = conversion.ConvertKelvinToFahrenheit();
                    Console.WriteLine(value + " kelvin is equal to " + convertedValue + " degree fahrenheit");
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    do
                    {
                        Console.WriteLine($"{Environment.NewLine}1. Convert Celsius to Fahrenheit");
                        Console.WriteLine("2. Convert Celsius to Kelvin");
                        Console.WriteLine("3. Convert Fahrenheit to Celsius");
                        Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                        Console.WriteLine("5. Convert Kelvin to Celsius");
                        Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                        Console.WriteLine("7. Exit");

                        optionSelected = Console.ReadLine();

                        switch (optionSelected)
                        {
                            case "1":
                                Console.WriteLine("1");
                                break;
                            case "2":
                                Console.WriteLine("2");
                                break;
                            case "3":
                                Console.WriteLine("3");
                                break;
                            case "4":
                                Console.WriteLine("4");
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                            case "7":
                                Environment.Exit(0);
                                break;
                        }

                    }
                    while (optionSelected != "1" && optionSelected != "2" && optionSelected != "3" && optionSelected != "4" && optionSelected != "5" && optionSelected != "6" && optionSelected != "7");
                    break;

            }
        }

        //converts the string the user entered to a number and passes the value
        private static bool isANumber(string input, out int value)
        {
            var isInputANumber = int.TryParse(input, out value);
            return isInputANumber;
        }

    }
}
