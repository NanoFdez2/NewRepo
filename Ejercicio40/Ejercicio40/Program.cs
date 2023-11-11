namespace Ejercicio40a.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double suma, resta, multiplicacion, division;
            Console.WriteLine("Ingrese el primer número:");
            var num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            var num2 = Double.Parse(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;
            Console.WriteLine("Ingrese si la cuenta es (S)uma, (R)esta, (M)ultiplicación o (D)ivisión:");
            var cuenta = Console.ReadLine();
            if (cuenta.ToLower() == "s") ;
            {
                Console.WriteLine($"La suma es de {suma}");
            
            if (cuenta.ToLower() == "r") ;
            
                Console.WriteLine($"La resta es de {resta}.");
            
            if (cuenta.ToLower() == "m") ;
            
                Console.WriteLine($"La multiplicación es de {multiplicacion}.");
            
            else if(cuenta.ToLower() == "d") ;
            
                Console.WriteLine($"La división es de {division}.");
            }
        }
    }
}