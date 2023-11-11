// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese un número decimal:");
var basediez = double.Parse(Console.ReadLine());
string nombre = "";
switch (basediez)
{
        case 0:
        nombre = "0000";
        break;
        case 1:
        nombre = "0001";
        break;
        case 2:
        nombre = "0010";
        break;
        case 3:
        nombre = "0011";
        break;
        case 4:
        nombre = "0100";
        break;
        case 5:
        nombre = "0101";
        break;
        case 6:
        nombre = "0110";
        break;
        case 7:
        nombre = "0111";
        break;
        case 8:
        nombre = "1000";
        break;
        case 9:
        nombre = "1001";
        break;
}
Console.WriteLine($"El número {basediez} equivale a {nombre} en binario.");