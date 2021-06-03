using System;
using System.Collections.Generic;

namespace TreinoUri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            string[] values = Console.ReadLine().Split(' ');

            int primeiroValor = int.Parse(values[0]);
            int segundoValor = int.Parse(values[1]);

            int soma = 0;


            while (!(primeiroValor <= 0 || segundoValor <= 0))
            {


                if (primeiroValor > segundoValor)
                {

                    while (primeiroValor != segundoValor)
                    {

                        lista.Add(primeiroValor);
                        primeiroValor -= 1;


                        if (primeiroValor == segundoValor)
                        {
                            lista.Add(primeiroValor);
                        }
                    }


                    lista.Sort();


                    foreach (int obj in lista)
                    {
                        soma += obj;
                        Console.Write($"{obj} ");
                    }

                    Console.WriteLine($"Sum={soma}");
                }


                else if (segundoValor > primeiroValor)
                {
                    while (primeiroValor != segundoValor)
                    {
                        lista.Add(segundoValor);
                        segundoValor -= 1;

                        if (primeiroValor == segundoValor)
                        {
                            lista.Add(segundoValor);
                        }
                    }


                    lista.Sort();

                    foreach (int obj in lista)
                    {
                        soma += obj;
                        Console.Write($"{obj} ");
                    }

                    Console.WriteLine($"Sum={soma}");
                }


                soma = 0;
                lista.Clear();


                values = Console.ReadLine().Split(' ');

                primeiroValor = int.Parse(values[0]);
                segundoValor = int.Parse(values[1]);

            }
        }
    }
}







