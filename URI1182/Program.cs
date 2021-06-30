using System;
using System.Globalization;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] matriz = new double[12, 12];


            int coluna = int.Parse(Console.ReadLine());

            char validacao = char.Parse(Console.ReadLine());
            double soma = 0;

            if (coluna >= 0 && coluna <= 11)
            {

                for (int i = 0; i < 12; i++)
                {

                    for (int j = 0; j < 12; j++)
                    {
                        matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                }


                for (int k = 0; k < 12; k++)
                {
                    soma += matriz[k, coluna];
                }


                if (validacao == 'S')
                {
                    Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
                }


                else if (validacao == 'M')
                {
                    double media = soma / 12;
                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}