﻿using System;

double pmayor = 0;
double pmenor = 0;
double contadorpersonas = 0;
double personas25a40 = 0;
double edad = 0;
Console.WriteLine("Ingrese la edad de una persona: (1000 para finalizar).");
Console.ReadLine();
while (edad == 1000)
{
    if (edad > 0)
    {
        contadorpersonas++;
    }
    if (edad >= 25 && edad <= 40)
    {
        personas25a40++;
    }
    if (edad > pmayor)
    {
        pmayor = edad;
    }
    if (edad < pmenor)
    {
        pmenor = edad;
    }

}
double promedio = edad / contadorpersonas ;
Console.WriteLine($"Hubo un total de {personas25a40} personas de entre 25 y 40 años.");
Console.WriteLine($"La edad más alta fue de: {pmayor}.");
Console.WriteLine($"La edad más baja fue de: {pmenor}.");
Console.WriteLine($"El promedio fue de: {promedio}.");