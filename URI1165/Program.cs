using System;
using System.Linq;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlador = int.Parse(Console.ReadLine());
            int[] vetor = new int[controlador];

            int auxiliadora = 1;
            int soma = 0;


            if (controlador >= 1 && controlador <= 100)
            {

                for (int i = 0; i < vetor.Count(); i++)
                {

                    int valor = int.Parse(Console.ReadLine());

                    if (auxiliadora >= 1 && auxiliadora <= Math.Pow(10, 7))
                    {
                        vetor[i] = valor;
                    }
                }


                foreach (int obj in vetor)
                {

                    while (auxiliadora <= obj)
                    {

                        if (obj % auxiliadora == 0)
                        {

                            soma += 1;

                        }

                        auxiliadora++;

                    }


                    if (soma != 2)
                    {

                        Console.WriteLine($"{obj} nao eh primo");

                    }


                    else if(soma == 2 && obj % 1 == 0 && obj % obj == 0)
                    {

                        Console.WriteLine($"{obj} eh primo");

                    }


                    auxiliadora = 1;
                    soma = 0;
                }
            }
        }
    }
}
