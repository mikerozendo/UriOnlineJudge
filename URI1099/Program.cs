using System;

namespace TreinoUri
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlador = int.Parse(Console.ReadLine());
            int soma = 0;


            for (int i = 0; i < controlador; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                int primeiroValor = int.Parse(values[0]);
                int segundoValor = int.Parse(values[1]);



                if (primeiroValor > segundoValor)
                {
                    if (primeiroValor - 1 != segundoValor)
                    {
                        while (primeiroValor - 1 != segundoValor)
                        {
                            primeiroValor -= 1;


                            if (primeiroValor % 2 != 0)
                            {
                                soma += primeiroValor;
                            }
                        }
                    }

                    Console.WriteLine(soma);
                    soma = 0;
                }

                else if (primeiroValor < segundoValor)
                {

                    if (primeiroValor + 1 != segundoValor)
                    {

                        while (primeiroValor + 1 != segundoValor)
                        {
                            primeiroValor += 1;


                            if (primeiroValor % 2 != 0)
                            {
                                soma += primeiroValor;
                            }
                        }
                    }

                    Console.WriteLine(soma);
                    soma = 0;
                }

                else if (primeiroValor == segundoValor)
                {
                    Console.WriteLine(soma);
                }
            }
        }
    }
}



