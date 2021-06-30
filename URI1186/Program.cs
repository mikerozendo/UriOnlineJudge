using System;
using System.Globalization;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] matriz = new double[12, 12];


            char validacao = char.Parse(Console.ReadLine());


            double soma = 0;
            int contador = 11;


            //Lendo valores da matriz 
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

            }


            //Filtrando valores
            for (int k = 1; k < 12; k++)
            {

                for (int f = 11; f >= contador; f--)
                {
                    soma += matriz[k , f];
                }

                contador--;
            }



            //Calculo mediante a validacao
            if (validacao == 'S')
            {

                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));

            }


            else if (validacao == 'M')
            {

                double media = soma / 66;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}