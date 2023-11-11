using ConsoleTables;
using Ejercicio02Bis.Utilidades;

namespace Ejercicio02Bis.Consola
{
    internal class Program
    {
        const double MinVelocidad = 100;
        const double MaxVelocidad = 300;

        static void Main(string[] args)
        {
            double[] velocidad = new double[10];
            bool seguir = true;
            do
            {
                mostrarMenu();
                int opcionSeleccionada =IngresoDatos.PedirIntEnRango("Seleccione:", 1, 7);
                switch (opcionSeleccionada)
                {
                    case 1:
                        GenerarVelocidades(velocidad);
                        break;
                    case 2:
                        ModificarDatos(velocidad);
                        break;
                    case 3:

                }

            } while (seguir);

        }

        private static void ModificarDatos(double[] velocidad)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Modificación de datos:");
                ListarVelocidades(velocidad);

                var index =IngresoDatos.PedirIntEnRango()
            }
    }

        private static void ListarVelocidades(double[] velocidad)
        {
            Console.Clear();
            Console.WriteLine("Listado de velocidades.");
            var tabla = new ConsoleTable("Km/h", "Millas");
            foreach (double velEnArray in velocidad)
            {
                var milla = ConvertToMilla(velEnArray);
                tabla.AddRow(velEnArray, milla);
            }
            Console.WriteLine(tabla.ToString());
            TareaFinalizada("Listado finalizado.");

        }

        private static double ConvertToMilla(double kmPorHora)
        {
            return kmPorHora / 1.609344;
        }

        private static void mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("1-Ingresar Datos");
            Console.WriteLine("2-Modificar Datos");
            Console.WriteLine("3-Listar Velocidad en millas");
            Console.WriteLine("4-Datos Estadísticos");
            Console.WriteLine("5-Marcar Superiores al Promedio");
            Console.WriteLine("6-Ver Inferiores al Promedio");
            Console.WriteLine("7-Salir");

        }

        private static void GenerarVelocidades(double[] velocidad)
        {
            Console.Clear();
            Console.WriteLine("Ingrese las velocidades:");
            for (int i = 0; i < velocidad.Length; i++)
            {
                double
                    velocidadIngresada =
                        IngresoDatos.PedirDoubleEnRango("Ingrese una velocidad: ", MinVelocidad, MaxVelocidad);
                velocidad[i] = velocidadIngresada;
            }

            TareaFinalizada("Ingreso finalizado");
        }

        private static void TareaFinalizada(string mensaje)
        {
            Console.WriteLine($"{mensaje}...ENTER para continuar");
            Console.ReadLine();
        }
    }
}