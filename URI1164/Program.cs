using System;


namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            int controlador = int.Parse(Console.ReadLine());
            int[] vetor = new int[controlador];

            int divisora = 1;
            int auxiliadoraSoma = 0;



            for (int i = 0; i < controlador; i++)
            {

                vetor[i] = int.Parse(Console.ReadLine());



                for (int j = vetor[i]; j >= 1; j--)
                {


                    if (vetor[i] % divisora == 0 && divisora != vetor[i])
                    {

                        auxiliadoraSoma += divisora;

                    }


                    divisora++;



                    if (j == 1 && auxiliadoraSoma == vetor[i])
                    {
                        Console.WriteLine($"{vetor[i]} eh perfeito");
                        divisora = 1;
                        auxiliadoraSoma = 0;
                    }


                    else if (j == 1 && auxiliadoraSoma != vetor[i])
                    {
                        Console.WriteLine($"{vetor[i]} nao eh perfeito");
                        divisora = 1;
                        auxiliadoraSoma = 0;
                    }
                }
            }
        }
    }
}
