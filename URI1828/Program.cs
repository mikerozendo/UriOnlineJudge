using System;


namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            int controlador = int.Parse(Console.ReadLine());


            if (controlador > 0 && controlador <= 100)
            {

                for (int i = 1; i <= controlador; i++)
                {

                    string[] values = Console.ReadLine().Split(' ');

                    string sheldon = values[0];
                    string raj = values[1];



                    if ((sheldon == "tesoura" && raj == "papel") ||
                        (sheldon == "papel" && raj == "pedra") ||
                        (sheldon == "pedra" && raj == "lagarto") ||
                        (sheldon == "lagarto" && raj == "Spock") ||
                        (sheldon == "Spock" && raj == "tesoura") ||
                        (sheldon == "tesoura" && raj == "lagarto") ||
                        (sheldon == "lagarto" && raj == "papel") ||
                        (sheldon == "papel" && raj == "Spock") ||
                        (sheldon == "Spock" && raj == "pedra") ||
                        (sheldon == "pedra" && raj == "tesoura"))
                    {


                        Console.WriteLine($"Caso #{i}: Bazinga!");

                    }

                    else if (sheldon == raj)
                    {
                        Console.WriteLine($"Caso #{i}: De novo!");
                    }

                    else
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                }
            }
        }
    }
}