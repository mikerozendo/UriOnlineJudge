using System;
using System.Globalization;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            int Controle1, Controle2, ControladorTeste;

            Controle1 = 1;
            Controle2 = 7;

            for (ControladorTeste = 0; ControladorTeste < 3; ControladorTeste += 1)
            {
                Console.Write("I=" + Controle1 + " ");
                Console.WriteLine("J=" + Controle2);

                Controle2 -= 1;
            }
            if (Controle2 == 4)
            {
                Controle1 = 3;
                Controle2 = 7;
            }
            for (ControladorTeste = 0; ControladorTeste < 3; ControladorTeste += 1)
            {
                Console.Write("I=" + Controle1 + " ");
                Console.WriteLine("J=" + Controle2);

                Controle2 -= 1;
            }
            if (Controle2 == 4)
            {
                Controle1 = 5;
                Controle2 = 7;
            }
            for (ControladorTeste = 0; ControladorTeste < 3; ControladorTeste += 1)
            {
                Console.Write("I=" + Controle1 + " ");
                Console.WriteLine("J=" + Controle2);

                Controle2 -= 1;
            }
            if (Controle2 == 4)
            {
                Controle1 = 7;
                Controle2 = 7;
            }
            for (ControladorTeste = 0; ControladorTeste < 3; ControladorTeste += 1)
            {
                Console.Write("I=" + Controle1 + " ");
                Console.WriteLine("J=" + Controle2);

                Controle2 -= 1;
            }
            if (Controle2 == 4)
            {
                Controle1 = 9;
                Controle2 = 7;
            }
            for (ControladorTeste = 0; ControladorTeste < 3; ControladorTeste += 1)
            {
                Console.Write("I=" + Controle1 + " ");
                Console.WriteLine("J=" + Controle2);

                Controle2 -= 1;
            }
        }
    }
}
