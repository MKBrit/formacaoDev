using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEscolha um exercício");
            for (int i = 1; i < 6; i++)
                {
                Console.WriteLine($"{i}. Exercício");
                }
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ex1();
                        break;
                    case 2:
                        ex2();
                        break;
                    case 3:
                        ex3();
                        break;
                    case 4:
                        ex4();
                        break;
                    case 5:
                        ex5();
                        break;
                    default:
                        Console.WriteLine("ya dense...");
                        break;
                }
            }
            //////////////////////////////////////////////////
            void ex1()
            {
                Console.Clear();
                int[] alay = new int[5];

                Console.WriteLine("Exercício 1");
                Console.WriteLine("Vamos introduzir 5 números!");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Introduza o {i + 1}º nr");
                    alay[i] = Convert.ToInt32(Console.ReadLine());
                }
                int total = alay.Sum();
                Console.WriteLine($"O total é de {total}.");
            }
            //////////////////////////////////////////////////
            void ex2()
            {
                Console.Clear();
                int[] alay = new int[10];

                Console.WriteLine("Exercício 2");
                Console.WriteLine("Vamos introduzir 10 números!");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Introduza o {i + 1}º nr");
                    alay[i] = Convert.ToInt32(Console.ReadLine());
                }
                double media = alay.Average();
                Console.WriteLine($"A média é de {media}.");
            }
            //////////////////////////////////////////////////
            void ex3()
            {
                Console.Clear();
                int[] alay = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

                Console.WriteLine("Exercício 3");
                for (int i = 8; i > 0; i--)
                {
                    Console.WriteLine($"A {i}º posição = {alay[i - 1]}");
                }
            }
            //////////////////////////////////////////////////
            void ex4()
            {
                Console.Clear();
                int[] alay = new int[7];

                Console.WriteLine("Exercício 4");
                Console.WriteLine("Vamos introduzir 7 números!");
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"Introduza o {i + 1}º nr");
                    alay[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = alay.Max();
                int min = alay.Min();
                Console.WriteLine($"O valor max é {max}, e o mínimo {min}.");
            }
            //////////////////////////////////////////////////
            void ex5()
            {
                Console.Clear();
                int[] alay = new int[6];
                Console.WriteLine("Exercício 5");
                Console.WriteLine("Vamos introduzir 6 números!");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"Introduza o {i + 1}º nr");
                    alay[i] = Convert.ToInt32(Console.ReadLine());
                }
                int produto = 1;
                foreach (int n in alay) {
                    produto *= n;
                }
            Console.WriteLine($"E o produto final é de {produto}");
            }
        }
    }
}