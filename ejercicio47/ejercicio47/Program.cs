// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Ejercicio47.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciclos anidados");
            int mayor = 0;
            int sumaPares = 0;
            for (int i = 1; i <= 5; i++)
            {
                int valorEntero;
                do
                {
                    Console.Write("Ingrese un número entero:");
                    var str = Console.ReadLine();
                    if (int.TryParse(str, out valorEntero))
                    {
                        if (valorEntero >= 1 && valorEntero <= 100)
                        {
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Número fuera del rango permitido [1-100]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número no válido");

                    }

                } while (true);

                if (EsPar(valorEntero))
                {
                    sumaPares += valorEntero;
                }
                if (valorEntero > mayor)
                {
                    mayor = valorEntero;
                }
            }
            Console.WriteLine($"La suma de los pares es {sumaPares}");
            Console.WriteLine($"El mayor ingresado es {mayor}");
        }

        private static bool EsPar(int valorEntero) => valorEntero % 2 == 0;
    }
}