﻿using System;

public class Totoloto
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma conversão");
            Console.WriteLine("1. Celsius > Fahrenheit");
            Console.WriteLine("2. Fahrenheit > Celsius");
            Console.WriteLine("3. Milhas > Kilometros");
            Console.WriteLine("4. Kilometros > Milhas");
            Console.WriteLine("5. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                double result;
                switch (choice)
                {
                    case 1:
                        Console.Write("Introduza temperatura em Celsius ");
                        if (double.TryParse(Console.ReadLine(), out double celsius))
                        {
                            result = CelsiusToFahrenheit(celsius);
                            Console.WriteLine($"Fahrenheit: {result}");
                        }
                        else
                        {
                            Console.WriteLine("ya dense...");
                        }
                        break;

                    case 2:
                        Console.Write("Introduza temperatura em Fahrenheit ");
                        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                        {
                            result = FahrenheitToCelsius(fahrenheit);
                            Console.WriteLine($"Celsius: {result}");
                        }
                        else
                        {
                            Console.WriteLine("ya dense...");
                        }
                        break;

                    case 3:
                        Console.Write("Introduza milhas ");
                        if (double.TryParse(Console.ReadLine(), out double miles))
                        {
                            result = MilesToKilometers(miles);
                            Console.WriteLine($"Kilometros: {result}");
                        }
                        else
                        {
                            Console.WriteLine("ya dense...");
                        }
                        break;

                    case 4:
                        Console.Write("Introduza kms ");
                        if (double.TryParse(Console.ReadLine(), out double kilometers))
                        {
                            result = KilometersToMiles(kilometers);
                            Console.WriteLine($"Milhas: {result}");
                        }
                        else
                        {
                            Console.WriteLine("ya dense...");
                        }
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("ya dense...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ya dense...");
            }
        Console.WriteLine();
        }
    }


    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double MilesToKilometers(double miles)
    {
        return miles * 1.60934;
    }

    static double KilometersToMiles(double kilometers)
    {
        return kilometers / 1.60934;
    }
}