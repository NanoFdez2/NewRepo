// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese un número mayor que 1:");
var num = double.Parse(Console.ReadLine());
//while (num > 1)
//{
//    Console.WriteLine("Número no válido.");
//    Console.WriteLine("Ingrese un número mayor que uno: ");
//    Console.ReadLine();
//}
if (num % num == 0 && num % 2 ==0 || num % 5 == 0)
{
    Console.WriteLine($"El número {num} es primo.");
}
else
{
    Console.WriteLine($"El número {num} no es primo.");
}