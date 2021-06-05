using System;
using System.Linq;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[20];
            int controladora = 19;
            int auxiliadora;



            for (int i = 0; i < Vetor.Count(); i++)
            {

                Vetor[i] = int.Parse(Console.ReadLine());

            }



            for (int j = 0; j < Vetor.Count(); j++)
            {

                if (controladora >= 10)
                {

                    auxiliadora = Vetor[controladora];
                    Vetor[controladora] = Vetor[j];

                    Vetor[j] = auxiliadora;
                    controladora--;

                }
            }



            for (int k = 0; k < Vetor.Count(); k++)
            {
                Console.WriteLine($"N[{k}] = {Vetor[k]}");
            }

        }
    }
}
