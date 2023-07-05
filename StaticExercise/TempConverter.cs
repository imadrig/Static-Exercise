using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempInFahrenheit)
        {
            double celsius = (tempInFahrenheit - 32) * 5 / 9;
            return celsius;

            

        }

        public static double CelsiusToFahrenheit(double tempInCelsius)
        {
            double fahrenheit = (tempInCelsius * 9 / 5) + 32;
            return fahrenheit;

            


        }



    }
}
