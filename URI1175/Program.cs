using System;

namespace UriOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeticao; i++)
            {
                if (i <= repeticao - 2)
                {
                    Console.Write("Ho ");
                }

                if (i == repeticao - 1)
                {
                    Console.Write("Ho");
                }

                if (i == repeticao - 1)
                {
                    Console.Write("!");
                }
            }



        }
    }
}

