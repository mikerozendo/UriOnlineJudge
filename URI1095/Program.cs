using System;
using System.Globalization;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiraAuxiliar = 1;
            int segundaAuxiliar = 60;

            while (segundaAuxiliar != 0)
            {
                Console.WriteLine($"I={primeiraAuxiliar} J={segundaAuxiliar}");
                primeiraAuxiliar += 3;
                segundaAuxiliar -= 5;
            }

            Console.WriteLine($"I={primeiraAuxiliar} J={segundaAuxiliar}");
        }
    }
}
