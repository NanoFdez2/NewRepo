// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio43");
//definir nota1, nota2, nota3 Como Real;
//Definir promedio como real;
//Escribir "Ingrese la 1er nota: ";
//leer nota1;
//Escribir "Ingrese la 2da nota: ";
//leer nota2;
//Escribir "Ingrese la 3er  nota: ";
//leer nota3;
Console.WriteLine("Ingrese la 1er nota:");
var nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la 2da nota:");
var nota2 = double.Parse(Console.ReadLine()); ;
Console.WriteLine("Ingrese la 3er nota:");
var nota3 = double.Parse(Console.ReadLine());
double promedio;
promedio = (nota1 + nota2 + nota3)/3;
if (promedio >= 1 && promedio <= 4)
{
    Console.Write($"El alumno está aplazado con promedio: {promedio}.");
}
else if (promedio >= 5 && promedio <= 6)
{
    Console.Write($"El alumno desaprobó con promedio: {promedio}.");
}
else if (promedio >= 7 && promedio <= 8)
{
    Console.Write($"El alumndo aprobó con promedio: {promedio}.");
}
else if (promedio >= 9 && promedio < 10)
{
    Console.Write($"El alumno tuvo {promedio}, promedio notable.");
}
else
{
    Console.WriteLine($"El alumno tuvo {promedio}, promedio sobresaliente.");
}
