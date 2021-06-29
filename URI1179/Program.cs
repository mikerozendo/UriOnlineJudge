using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;


namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pares = new int[5];
            int[] impares = new int[5];


            int contadoraPares = 0;
            int contadoraImpares = 0;



            for (int i = 0; i < 15; i++)
            {

                int auxiliar = int.Parse(Console.ReadLine());



                if (auxiliar % 2 == 0)
                {

                    pares[contadoraPares] = auxiliar;



                    if (contadoraPares == 4)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"par[{j}] = {pares[j]}");
                        }

                        contadoraPares = 0;
                    }


                    else
                    {
                        contadoraPares++;
                    }

                }




                else
                {

                    impares[contadoraImpares] = auxiliar;



                    if (contadoraImpares == 4)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"impar[{j}] = {impares[j]}");
                        }

                        contadoraImpares = 0;
                    }


                    else
                    {

                        contadoraImpares++;

                    }

                }
            }




            for (int j = 0; j < contadoraImpares; j++)
            {
                Console.WriteLine($"impar[{j}] = {impares[j]}");
            }



            for (int k = 0; k < contadoraPares; k++)
            {
                Console.WriteLine($"par[{k}] = {pares[k]}");
            }

        }
    }
}