using System;


namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlador = int.Parse(Console.ReadLine());
            int[] vetor = new int[controlador];

            int menor = 0;
            int posicao = 0;

            string[] values = Console.ReadLine().Split(' ');


            for (int i = 0; i < controlador; i++)
            {

                vetor[i] = int.Parse(values[i]);


                if (i == 0)
                {

                    menor = vetor[i];
                    posicao = i;

                }


                else if (i != 0)
                {

                    if (vetor[i] < menor)
                    {

                        menor = vetor[i];
                        posicao = i;

                    }
                }
            }


            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Posicao: {posicao}");
        }
    }
}
