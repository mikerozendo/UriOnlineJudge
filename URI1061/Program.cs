using System;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int diaInicio = int.Parse(values[1]);


            string[] valuesHorario = Console.ReadLine().Split(':');


            int horas = int.Parse(valuesHorario[0]);
            int minutos = int.Parse(valuesHorario[1]);
            int segundos = int.Parse(valuesHorario[2]);


            DateTime primeiro = new DateTime(1, 1, diaInicio, horas, minutos, segundos);



            values = Console.ReadLine().Split(' ');
            int diaTermino = int.Parse(values[1]);


            valuesHorario = Console.ReadLine().Split(':');


            horas = int.Parse(valuesHorario[0]);
            minutos = int.Parse(valuesHorario[1]);
            segundos = int.Parse(valuesHorario[2]);


            DateTime segundo = new DateTime(1, 1, diaTermino, horas, minutos, segundos);
            TimeSpan duracao = segundo - primeiro;



            if (duracao.TotalMinutes >= 1)
            {

                Console.WriteLine($"{duracao.Days} dia(s)");
                Console.WriteLine($"{duracao.Hours} hora(s)");
                Console.WriteLine($"{duracao.Minutes} minuto(s)");
                Console.WriteLine($"{duracao.Seconds} segundo(s)");

            }

        }
    }
}
