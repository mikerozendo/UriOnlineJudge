using System;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');


            int horaInicial = int.Parse(values[0]);
            int minutoInicial = int.Parse(values[1]);
            int horaFinal = int.Parse(values[2]);
            int minutoFinal = int.Parse(values[3]);



            if (horaInicial == minutoInicial &&
                horaInicial == minutoFinal &&
                horaInicial == horaFinal &&
                horaFinal == minutoFinal &&
                horaFinal == minutoInicial)
            {

                DateTime inicio = new DateTime(1, 1, 1, horaInicial, 0, 0);
                DateTime fim = new DateTime(1, 1, 2, horaInicial, 0, 0);

                TimeSpan duracao = fim - inicio;

                Console.WriteLine($"O JOGO DUROU {duracao.TotalHours} HORA(S) E {duracao.Minutes} MINUTO(S)");
            }



            else if (horaFinal > horaInicial)
            {

                DateTime inicio = new DateTime(1, 1, 1, horaInicial, minutoInicial, 0);
                DateTime fim = new DateTime(1, 1, 1, horaFinal, minutoFinal, 0);

                TimeSpan duracao = fim - inicio;

                Console.WriteLine($"O JOGO DUROU {duracao.Hours} HORA(S) E {duracao.Minutes} MINUTO(S)");
            }


            else 
            {

                DateTime inicio = new DateTime(1, 1, 1, horaInicial, minutoInicial, 0);
                DateTime fim = new DateTime(1, 1, 2, horaFinal, minutoFinal, 0);

                TimeSpan duracao = fim - inicio;

                Console.WriteLine($"O JOGO DUROU {duracao.Hours} HORA(S) E {duracao.Minutes} MINUTO(S)");
            }
        }

    }
}

