namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(55);

            Console.WriteLine($"{celsius} celsius");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(32);

            Console.WriteLine($"{fahrenheit} fahrenheit");
        }
    }
}
