using System;
using System.Globalization;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            double segundoValor = 0;
            double auxiliadora = 0;

            int contador = 0;

            for (double i = 0; i < 2; i += 0.2)
            {

                if (i == 0)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        i = (int)i;

                        Console.WriteLine($"I={i} J={j}");

                    }
                }



                else if (i < 2 && i > 0 && contador != 4)
                {

                    for (double k = 1; k <= 3; k++)
                    {

                        auxiliadora = k + segundoValor;

                        Console.WriteLine($"I={i.ToString("F1", CultureInfo.InvariantCulture)} J={auxiliadora.ToString("F1", CultureInfo.InvariantCulture)}");

                    }
                    contador++;
                }


                else if (contador == 4)
                {
                    for (double f = 1; f <= 3; f++)
                    {

                        auxiliadora = (int)f + segundoValor;

                        Console.WriteLine($"I={i.ToString("F0", CultureInfo.InvariantCulture)} J={auxiliadora}");

                    }
                    contador = 0;
                }




                /*
                else if (i == 2)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        Convert.ToInt32(i);
                        Console.WriteLine($"I={i} J={k + segundoValor.ToString("F1", CultureInfo.InvariantCulture)}");

                    }
                }
                */
                segundoValor += 0.2;

            }
        }
    }
}