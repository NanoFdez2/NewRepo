// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");
//Definir peso Como Real;
//Definir contador Como Real;
//Definir semimosca, promSemimosca Como Real;
//Definir mosca, promMosca Como Real;
//Definir gallo, promGallo Como Real;
//Definir pluma, promPluma Como Real;
//Definir ligero, promLigero Como Real;
//Definir superligero, promSuperL Como Real;
//Definir welter, promWelter Como Real;
//Definir medio, promMedio Como Real;
//Definir semipesado, promSemipesado Como Real;
//Definir pesado, promPesado Como Real;
//Definir superpesado, promSuperP Como Real;

double peso;
double contador = 0;
double semimosca = 0, promSemimosca = 0;
double mosca = 0, promMosca  = 0;
double gallo = 0, promGallo = 0;
double pluma = 0, promPluma = 0;
double ligero = 0, promLigero = 0;
double superligero = 0, promSuperL = 0;
double welter = 0, promWelter = 0;
double medio = 0, promMedio = 0;
double semipesado = 0, promSemiP = 0;
double pesado = 0, promPesado = 0;
double superpesado = 0, promSuperP = 0;

do
{
    Console.WriteLine("Ingrese un peso entre 40 kg y 100kg.");
    peso = double.Parse(Console.ReadLine());
        if (peso >= 40 && peso <= 50)
        {
            Console.WriteLine("Corresponde a semimosca.");
            semimosca++;
            contador++;
        }
            if (peso >= 51 && peso <= 53)
            {
                Console.WriteLine("Corresponde a mosca.");
                mosca++;
                contador++;
            }

                if (peso >= 54 && peso <= 56)
                {
                    Console.WriteLine("Corresponde a gallo");
                    gallo++;
                    contador++;
                }

                    if (peso >= 57 && peso <= 59)
                    {
                        Console.WriteLine("Corresponde a pluma.");
                        pluma++;
                        contador++;
                    }

                        if (peso >= 60 && peso <= 63)
                        {
                            Console.WriteLine("Corresponde a ligero.");
                            ligero++;
                            contador++;
                        }

                            if (peso >= 64 && peso <= 68)
                            {
                                Console.WriteLine("Corresponde a superligero.");
                                superligero++;
                                contador++;
                            }

                                if (peso >= 69 && peso <= 74)
                                {
                                    Console.WriteLine("Corresponde a welter.");
                                    welter++;
                                    contador++;
                                }

                                    if (peso >= 75 && peso <= 80)
                                    {
                                        Console.WriteLine("Corresponde a mediano.");
                                        medio++;
                                        contador++;
                                    }

                                        if (peso >= 81 && peso <= 90)
                                        {
                                            Console.WriteLine("Corresponde a semipesado.");
                                            semipesado++;
                                            contador++;
                                        }

                                            if (peso == 90)
                                            {
                                                Console.WriteLine("Corresponde a pesado");
                                                pesado++;
                                                contador++;
                                            }

                                                if (peso >= 91)
                                                {
                                                    Console.WriteLine("Corresponde a superpesado.");
                                                    superpesado++;
                                                    contador++;
                                                }
} while (contador < 15);
promSemimosca = contador / semimosca;
promMosca = contador / mosca;
promGallo = contador / gallo;
promPluma = contador / pluma;
promLigero = contador / ligero;
promSuperL = contador / superligero;
promWelter = contador / welter;
promMedio = contador / medio;
promSemiP = contador / semipesado;
promPesado = contador / pesado;
promSuperP = contador / superpesado;

Console.WriteLine($"Se ingresaron un total de {contador} pesos.");
Console.WriteLine($"{semimosca} Fueron semimosca, un {promSemimosca}%.");
Console.WriteLine($"{mosca} Fueron mosca, un {promMosca}%.");
Console.WriteLine($"{gallo} Fueron gallo, un {promGallo}%.");
Console.WriteLine($"{pluma} Fueron pluma, un {promPluma}%.");
Console.WriteLine($"{ligero} Fueron ligero, un {promLigero}%.");
Console.WriteLine($"{superligero} Fueron superligero, un {promSuperL}%.");
Console.WriteLine($"{welter} Fueron welter, un {promWelter}%.");
Console.WriteLine($"{semipesado} Fueron semipesado, un {promSemiP}%.");
Console.WriteLine($"{pesado} Fueron pesado, un {promPesado}%.");
Console.WriteLine($"{superpesado} Fueron superpesado, un {promSuperP}%.");