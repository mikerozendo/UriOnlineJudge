using System;
using System.Globalization;

namespace TreinoUri
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadoraNotasCEM = 0;
            int contadoraNotasCinquenta = 0;
            int contadoraNotasVinte = 0;
            int contadoraNotasDez = 0;
            int contadoraNotasCinco = 0;
            int contadoraNotasDois = 0;


            int contadoraMoedasUm = 0;
            int contadoraMoedasCinquenta = 0;
            int contadoraMoedasVinteCinco = 0;
            int contadoraMoedasDez = 0;
            int contadoraMoedasCinco = 0;
            int contadoraMoedasZeroUm = 0;



            decimal valorEntrada = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal auxiliadora = valorEntrada;


            if (valorEntrada >= 0 && valorEntrada <= 1000000)
            {
                if (auxiliadora >= 100)
                {
                    do
                    {
                        auxiliadora -= 100;
                        contadoraNotasCEM += 1;
                    } while (auxiliadora >= 100);
                }


                if (auxiliadora >= 50)
                {
                    do
                    {
                        auxiliadora -= 50;
                        contadoraNotasCinquenta += 1;
                    } while (auxiliadora >= 50);
                }


                if (auxiliadora >= 20)
                {
                    do
                    {
                        auxiliadora -= 20;
                        contadoraNotasVinte += 1;
                    } while (auxiliadora >= 20);
                }


                if (auxiliadora >= 10)
                {
                    do
                    {
                        auxiliadora -= 10;
                        contadoraNotasDez += 1;
                    } while (auxiliadora >= 10);
                }


                if (auxiliadora >= 5)
                {
                    do
                    {
                        auxiliadora -= 5;
                        contadoraNotasCinco += 1;
                    } while (auxiliadora >= 5);
                }


                if (auxiliadora >= 2)
                {
                    do
                    {
                        auxiliadora -= 2;
                        contadoraNotasDois += 1;
                    } while (auxiliadora >= 2);
                }




                if (auxiliadora >= 1)
                {
                    do
                    {
                        auxiliadora -= 1;
                        contadoraMoedasUm += 1;
                    } while (auxiliadora >= 1);
                }


                if (auxiliadora >= 0.50m)
                {
                    do
                    {
                        auxiliadora -= 0.50m;
                        contadoraMoedasCinquenta += 1;
                    } while (auxiliadora >= 0.50m);
                }


                if (auxiliadora >= 0.25m)
                {
                    do
                    {
                        auxiliadora -= 0.25m;
                        contadoraMoedasVinteCinco += 1;
                    } while (auxiliadora >= 0.25m);
                }


                if (auxiliadora >= 0.10m)
                {
                    do
                    {
                        auxiliadora -= 0.10m;
                        contadoraMoedasDez += 1;
                    } while (auxiliadora >= 0.10m);
                }


                if (auxiliadora >= 0.05m)
                {
                    do
                    {
                        auxiliadora -= 0.05m;
                        contadoraMoedasCinco += 1;
                    } while (auxiliadora >= 0.05m);
                }


                if (auxiliadora >= 0.01m)
                {
                    do
                    {
                        auxiliadora -= 0.01m;
                        contadoraMoedasZeroUm += 1;
                    } while (auxiliadora >= 0.01m);
                }
            }


            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{contadoraNotasCEM} nota(s) de R$ 100.00");
            Console.WriteLine($"{contadoraNotasCinquenta} nota(s) de R$ 50.00");
            Console.WriteLine($"{contadoraNotasVinte} nota(s) de R$ 20.00");
            Console.WriteLine($"{contadoraNotasDez} nota(s) de R$ 10.00");
            Console.WriteLine($"{contadoraNotasCinco} nota(s) de R$ 5.00");
            Console.WriteLine($"{contadoraNotasDois} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{contadoraMoedasUm} moeda(s) de R$ 1.00");
            Console.WriteLine($"{contadoraMoedasCinquenta} moeda(s) de R$ 0.50");
            Console.WriteLine($"{contadoraMoedasVinteCinco} moeda(s) de R$ 0.25");
            Console.WriteLine($"{contadoraMoedasDez} moeda(s) de R$ 0.10");
            Console.WriteLine($"{contadoraMoedasCinco} moeda(s) de R$ 0.05");
            Console.WriteLine($"{contadoraMoedasZeroUm} moeda(s) de R$ 0.01");


        }
    }
}

