using System;
using System.Collections.Generic;
using System.Linq;

namespace TreinoUri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int primeiroValor = int.Parse(Console.ReadLine());
            int segundoValor = int.Parse(Console.ReadLine());


            int auxiliadora = 0;
            if (primeiroValor > 0 && segundoValor > 0 && primeiroValor != segundoValor)
            {


                if (primeiroValor > segundoValor)
                {

                    auxiliadora = segundoValor + 1;

                    if (auxiliadora % 5 == 2 || auxiliadora % 5 == 3)
                    {

                        valores.Add(auxiliadora);

                    }

                    while (primeiroValor != auxiliadora)
                    {
                        auxiliadora++;


                        if (auxiliadora % 5 == 2 || auxiliadora % 5 == 3)
                        {
                            valores.Add(auxiliadora);                          

                        }

                    }

                }


                else if (segundoValor > primeiroValor)
                {


                    auxiliadora = segundoValor - 1;

                    if (auxiliadora % 5 == 2 || auxiliadora % 5 == 3)
                    {

                        valores.Add(auxiliadora);

                    }

                    while (primeiroValor != auxiliadora)
                    {
                        auxiliadora--;


                        if (auxiliadora % 5 == 2 || auxiliadora % 5 == 3)
                        {
                            valores.Add(auxiliadora);

                        }
                    }          
                }



                valores.RemoveAll(x => x == primeiroValor);
                valores.RemoveAll(x => x == segundoValor);
                valores.Sort();

                foreach (int obj in valores)
                {
                    Console.WriteLine(obj);
                }

            }

        }
    }
}