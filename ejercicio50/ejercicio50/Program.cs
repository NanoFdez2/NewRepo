// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Ejercicio50Curso2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Semana que viene ver la funcion para ingresar datos
            //y la consola avanzada
            //Hacer una dll
            try
            {
                int valorInicial = 0, valorFinal = 0;
                do
                {
                    Console.Write("Ingrese el valor inicial en celsius:");
                    var str = Console.ReadLine();
                    if (int.TryParse(str, out valorInicial))
                    {
                        break;
                    }
                    Console.WriteLine("Número no válido");

                } while (true);

                do
                {
                    Console.Write("Ingrese el valor final en celsius:");
                    var str = Console.ReadLine();
                    if (int.TryParse(str, out valorFinal))
                    {
                        break;
                    }
                    Console.WriteLine("Número no válido");

                } while (true);

                Console.WriteLine("Tabla de Conversiones");

                if (valorInicial < valorFinal)
                {
                    for (int celsius = valorInicial; celsius <= valorFinal; celsius++)
                    {
                        var fahrenheit = ConvertirCelsiusFahrenheit(celsius);
                        Console.WriteLine($"{celsius} - {fahrenheit:N2}");
                    }

                }
                else
                {
                    for (int celsius = valorInicial; celsius >= valorFinal; celsius--)
                    {
                        var fahrenheit = ConvertirCelsiusFahrenheit(celsius);
                        Console.WriteLine($"{celsius} - {fahrenheit:N2}");
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Algo anda mal consultar a Cristian");
            }
        }

        private static double ConvertirCelsiusFahrenheit(int celsius) => 1.8 * celsius + 32;

    }
}