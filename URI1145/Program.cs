using System;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');


            int primeiroValor = int.Parse(values[0]);
            int segundoValor = int.Parse(values[1]);
            int controlador = 1;

            if (primeiroValor > 1 && primeiroValor < 20 && segundoValor > primeiroValor && segundoValor < 100000)
            {


                for (int i = 1; i <= segundoValor; i++)
                {

                    


                    if (controlador == primeiroValor)
                    {
                        Console.Write($"{i}");
                        Console.WriteLine();
                        controlador = 1;
                    }



                    else
                    {
                        Console.Write($"{i} ");
                        controlador++;
                    }
                }
            }   
        }
    }
}
