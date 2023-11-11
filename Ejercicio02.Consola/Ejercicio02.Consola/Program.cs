// See https://aka.ms/new-console-template for more information
using ConsoleTables;

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
            int opcionSeleccionada = PedirIntEnRango("Seleccione:", 1, 7);
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

        static int PedirIntEnRango(string mensaje, int minVelocidad, int maxVelocidad)
        {
            bool error = true;
            int valorInt;
            string? cX;
            do
            {
                cX = PedirString(mensaje);
                if (!int.TryParse(cX, out valorInt))
                {
                    Console.WriteLine("Error al intentar ingresar un valor entero.");
                }
                else if (valorInt < minVelocidad || valorInt > maxVelocidad)
                {
                    Console.WriteLine($"ERROR valor fuera del rango permitido {minVelocidad} y {maxVelocidad}.");
                }
                else
                {
                    error = false;
                }
            } while (error);

            return valorInt;
        }

        void mostrarMenu()
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

        void GenerarVelocidades(double[] velocidad)
        {
            Console.Clear();
            Console.WriteLine("Ingrese las velocidades:");
            for (int i = 0; i < velocidad.Length; i++)
            {
                double 
                    velocidadIngresada =
                        PedirDoubleEnRango("Ingrese una velocidad: ", MinVelocidad, MaxVelocidad);
                velocidad[i] = velocidadIngresada;
            }
            
            TareaFinalizada("Ingreso finalizado");
        }

        void TareaFinalizada(string mensaje)
        {
            Console.WriteLine($"{mensaje}...ENTER para continuar");
            Console.ReadLine();
        }

        double PedirDoubleEnRango(string mensaje, double minVelocidad, double maxVelocidad)
        {
            bool error = true;
            double valorDouble;
            string? cX;
            do
            {
                cX = PedirString(mensaje);
                if (!double.TryParse(cX, out valorDouble))
                {
                    Console.WriteLine("Error al intentar ingresar un valor entero.");
                }
                else if (valorDouble < minVelocidad || valorDouble > maxVelocidad)
                {
                    Console.WriteLine($"ERROR valor fuera del rango permitido {minVelocidad} y {maxVelocidad}.");
                }
                else
                {
                    error = false;
                }
            } while (error);

            return valorDouble;
        }

        string? PedirString(string mensaje)
        {
            string? cX;
            do
            {

                Console.Write(mensaje);
                cX = Console.ReadLine();
                if (!string.IsNullOrEmpty(cX) || !string.IsNullOrWhiteSpace(cX))
                {
                    break;
                }
                Console.WriteLine("No ingresó nada por la consola.");
            } while (true);
            return cX;
        }

        Console.WriteLine("Tarea finalizada.");
    }

    private static void ModificarDatos(double[] velocidad)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Modificación de datos:");
            ListarVelocidades(velocidad);

            var index = PedirIntEnRango()
        }
    }

    private static void ListarVelocidades(double[] velocidad)
    {
        Console.Clear ();
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

    private static void TareaFinalizada(string mensaje)
    {
        Console.WriteLine($"{mensaje}...Presione ENTER para continuar.");
        Console.ReadLine();
    }

    private static object ConvertToMilla(double kmPorHora) => kmPorHora / 1.609344; 
}