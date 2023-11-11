// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Definir num Como Real;
//Definir sumaNros Como Real;
//Definir contador Como real;
double sumaNros;
double contador;
contador = 0;
sumaNros = 0;
while (sumaNros < 60) 
{
    Console.Write("Ingrese un número a sumar:");
var num=double.Parse(Console.ReadLine());
    contador++;
    sumaNros = sumaNros + num;

}
Console.WriteLine($"Se ingresaron un total de: {contador} números.");
Console.WriteLine($"La suma total fue de: {sumaNros}.");