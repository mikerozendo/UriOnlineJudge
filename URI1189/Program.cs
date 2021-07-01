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



            //Variaveis auxiliares
            int contador = 11;
            int contadora = 1;



            //Lendo valores da matriz 
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

            }



            //Filtrando
            for (int i = 0; i <= 4; i++)
            {

                for (int j = contadora; j < contador; j++)
                {

                    soma += matriz[j, i];

                }

                contadora++;
                contador--;
            }



            //Calculo mediante a validacao
            if (validacao == 'S')
            {

                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));

            }



            else if (validacao == 'M')
            {

                double media = soma / 30;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}