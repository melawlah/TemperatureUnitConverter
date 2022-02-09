using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Conversion
    {
        private readonly int _conversionValue;
        
        public Conversion() 
        {
            _conversionValue = 1;
        }

        public Conversion(int inputValue)
        {
            _conversionValue = inputValue;

        }

        public double ConvertCelsiusToFahrenheit()
        {
            double celsiusToFahrenheit = (9 / 5.0 * _conversionValue) + 32;
            return celsiusToFahrenheit;
        }

        public double ConvertCelsiusToKelvin()
        {
            double celsiusToKelvin = _conversionValue + 273.15;
            return celsiusToKelvin;
        }

        public double ConvertKelvinToFahrenheit()
        {
            double kelvinToFahrenheit = (_conversionValue - 273.15) * 9 / 5.0 + 32;
            return kelvinToFahrenheit;
        }

        public double ConvertKelvinToCelsius()
        {
            double kelvinToCelsius = _conversionValue - 273.15;
            return kelvinToCelsius;
        }

        public double ConvertFahrenheitToKelvin()
        {
            double fahrenheitToKelvin = (_conversionValue - 32) * 5 / 9.0 + 273.15;
            return fahrenheitToKelvin;
        }

        public double ConvertFahrenheitToCelsius()
        {
            double fahrenheitToCelsius = (_conversionValue - 32) * 5 / 9.0;
            return fahrenheitToCelsius;
        }

    }
}
