using System;
using System.Linq;
using System.Globalization;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[100];


            for (int i = 0; i < vetor.Count(); i++)
            {

                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }


            for (int i = 0; i < vetor.Count(); i++)
            {

                if (vetor[i] <= 10)
                {

                    Console.WriteLine($"A[{i}] = {vetor[i].ToString("F1", CultureInfo.InvariantCulture)}");
                }

            }
        }
    }
}
