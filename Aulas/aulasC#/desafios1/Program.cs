using System;

public class Totoloto
{
    public static void Main()
    {
        //main loop
        while (true)
        {
            Console.WriteLine("Escolha uma conversão");
            Console.WriteLine("1. Fatorial de nr");
            Console.WriteLine("2. Guess 1 a 100");
            Console.WriteLine("3. Mario ou Luigi");// enganei-me a escrever maior, mas achei piada e complementei xD
            Console.WriteLine("4. Divisivel por 3");
            Console.WriteLine("5. Exit");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        fator(int nr)
                        break;

                    case 2:
                        guess();
                        break;

                    case 3:
                        mario();
                        break;

                    case 4:
                        divise();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("ya dense...");
                        break;
                }
            }
        }

        //funções
        void fator(int nr)
        {
            long factor = 1;
            Console.Write("Introduza um número: ");
            if (int.TryParse(Console.ReadLine(), out nr))
            {
                if (nr == 0 || nr == 1)
                {
                    factor = 1;
                }
                else
                {
                    for (int i = 2; i <= nr; i++)
                    {
                        factor *= i;
                    }
                }
                Console.WriteLine($"Fatorial: {factor}");
            }
            else
            {
                Console.WriteLine("ya dense...");
            }
        }

        void guess()
        {

        }

        void mario()
        {

        }

        void divise()
        {

        }

    }   