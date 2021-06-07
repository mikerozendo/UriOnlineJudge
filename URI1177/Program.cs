using System;
using System.Globalization;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorControle = int.Parse(Console.ReadLine());

            int[] vetor = new int[1000];
            int contador = 0;

            for (int i = 0; i < vetor.Length; i++)
            {


                if (contador == valorControle)
                {

                    contador = 0;
                    vetor[i] = contador;
                    contador += 1;

                }

                else
                {
                    vetor[i] = contador;
                    contador += 1;
                }
            }

            for (int j = 0; j < vetor.Length; j++)
            {
                Console.WriteLine($"N[{j}] = {vetor[j]}");
                
            }
        }
    }
}