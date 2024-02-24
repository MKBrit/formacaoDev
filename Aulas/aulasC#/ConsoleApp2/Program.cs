using System;

class Program
{
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Introduza temperatura em Fahrenheit: ");
            if (float.TryParse(Console.ReadLine(), out float temp))
            {
                Console.Clear();
                Console.WriteLine($"{temp:F2}\u00B0 Fahrenheit");
                float celsius = (temp - 32) * 5 / 9;
                Console.WriteLine($"{celsius:F2}\u00B0 Celsius");

                Console.WriteLine("\nPress any key to continue\nPress Esc to exit");
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Escape)
                {
                    flag = false;
                }
                else
                {
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Tente novamente.");
            }
        }
    }
}