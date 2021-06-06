using System;


namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorEntrada = int.Parse(Console.ReadLine());
            int soma = 0;

            int controlador = 0;

            while (valorEntrada != 0)
            {

                while (controlador != 5)
                {

                    if (valorEntrada % 2 == 0)
                    {
                        soma += valorEntrada;
                        controlador += 1;
                    }

                    valorEntrada += 1;
                }


                Console.WriteLine(soma);
                valorEntrada = int.Parse(Console.ReadLine());

                soma = 0;
                controlador = 0;
            }
        }
    }
}