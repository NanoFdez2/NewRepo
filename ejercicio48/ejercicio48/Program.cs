// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Ejercicio48.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumar números al generados azar");
            int sumaNumeros = 0;
            int cantidadNumeros = 0;
            Random r = new Random();//objeto de tipo random para generar nros al azar

            do
            {
                //Generar nro al azar
                var nroAzar = r.Next(1, 101);//genera nros entre 1 y 100
                cantidadNumeros++;
                sumaNumeros += nroAzar;
                Console.WriteLine($"{cantidadNumeros}º Nro Generado igual a {nroAzar}");
                if (sumaNumeros > 200)
                {
                    break;
                }

            } while (true);
            Console.WriteLine($"Se generaron {cantidadNumeros} numeros al azar");
            Console.WriteLine($"Su suma es {sumaNumeros}");
        }
    }
}