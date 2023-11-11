namespace Ejercicio02Bis.Utilidades
{
    public static class IngresoDatos
    {
        public static int PedirIntEnRango(string mensaje, int minVelocidad, int maxVelocidad)
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

        public static double PedirDoubleEnRango(string mensaje, double minVelocidad, double maxVelocidad)
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

        public static string? PedirString(string mensaje)
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

    }
}