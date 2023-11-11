// See https://aka.ms/new-console-template for more information
Console.WriteLine("La puta madre");
//Definir contador como real;
//Definir sumaNros Como Real;
//Definir nro como real;
double contador = 0;
double sumanros=0;
while (contador <10 )
{
    Console.Write("Ingrese un número:");
    var nro=double.Parse(Console.ReadLine());
    contador++;
    sumanros = sumanros + nro;
}
Console.WriteLine($"El total de la suma de {contador} números fue de {sumanros}.");

