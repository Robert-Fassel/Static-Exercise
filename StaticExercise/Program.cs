namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
