namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            double celsiusTemp = TempConverter.FahrenheitToCelsius(64);
            double tempInFahrenheit = 64;
            celsiusTemp = Math.Round(celsiusTemp, 2);
            Console.WriteLine($"The temperature is {tempInFahrenheit}\u00B0F or {celsiusTemp}\u00B0C");

            double fahrenheitTemp = TempConverter.CelsiusToFahrenheit(24);
            double tempInCelsius = 24;
            fahrenheitTemp = Math.Round(fahrenheitTemp, 2);
            Console.WriteLine($"The temperature is {tempInCelsius}\u00B0C or {fahrenheitTemp}\u00B0F");
        }
    }
}
