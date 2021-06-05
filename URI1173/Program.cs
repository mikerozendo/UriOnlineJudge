using System;
using System.Linq;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];


            int valor = int.Parse(Console.ReadLine());


            if (valor <= 50)
            {


                for (int i = 0; i < vetor.Count(); i++)
                {

                    vetor[i] = valor;
                    valor += valor;

                }


                for (int j = 0; j < vetor.Count(); j++)
                {

                    Console.WriteLine($"N[{j}] = {vetor[j]}");

                }
            }
        }
    }
}
