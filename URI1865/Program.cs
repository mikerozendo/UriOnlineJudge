using System;
using System.Globalization;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            int controlador = int.Parse(Console.ReadLine());


            for (int i = 0; i < controlador; i++)
            {

                string[] value = Console.ReadLine().Split(' ');

                string personagem = value[0];
                int newtons = int.Parse(value[1]);


                if (personagem == "Thor")
                {
                    Console.WriteLine("Y");
                }


                else
                {
                    Console.WriteLine("N");
                }
            }
        }
    }
}