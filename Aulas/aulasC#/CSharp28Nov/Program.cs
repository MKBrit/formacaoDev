﻿using System;

public class Totoloto
{
    public static void Main()
    {
        //main loop
        while (true)
        {
            Console.WriteLine("Escolha um exercício");
            Console.WriteLine("1. Exercício(Par/Ímpar )");
            Console.WriteLine("2. Exercício(Divisão)");
            Console.WriteLine("3. Exercício(Error on beep)");
            Console.WriteLine("4. Exercício(Naturais 1)");
            Console.WriteLine("5. Exercício(Naturais 2)");
            Console.WriteLine("6. Exercício(Naturais 3)");
            Console.WriteLine("7. Exercício(Naturais 4)");
            Console.WriteLine("8. Exercício(Cubos 1)");
            Console.WriteLine("9. Exercício(Cubos 2)");
            Console.WriteLine("10. Exercício(Guess)");
            Console.WriteLine("11. Exercício(Conversor)");
            Console.WriteLine("12. Exercício(Tabuada)");
            Console.WriteLine("13. Exercício(IMC)");
            Console.WriteLine("14. Exercício(Primos)");
            Console.WriteLine("15. Exercício(Fatorial)");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
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

                    case 6:
                        Console.Write("Digite o número de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n6))
                        {
                            ex6(n6);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
                        }
                        break;

                    case 7:
                        ex7();
                        break;

                    case 8:
                        Console.Write("Digite o número de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n8))
                        {
                            ex8(n8);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
                        }
                        break;

                    case 9:
                        Console.Write("Digite o número de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n9))
                        {
                            ex9(n9);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
                        }
                        break;

                    case 10:
                        ex10();
                        break;

                    case 11:
                        ex11();
                        break;

                    case 12:
                        ex12();
                        break;

                    case 13:
                        ex13();
                        break;

                    case 14:
                        Console.Write("Digite um número: ");
                        if (int.TryParse(Console.ReadLine(), out int n14))
                        {
                            bool Primo = ex14(n14);

                            if (Primo)
                            {
                                Console.WriteLine($"{n14} é um número primo.");
                            }
                            else
                            {
                                Console.WriteLine($"{n14} não é um número primo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
                        }
                        break;

                    case 15:
                        Console.Write("Digite um número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            long fatorial = ex15(numero);

                            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
                        };
                        break;

                    default:
                        Console.WriteLine("ya dense...");
                        break;
                }
            }
        }
    }   

    //funções
    static void ex1()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        Console.WriteLine($"A soma dos números é: {soma}");

        if (soma % 2 != 0)
        {
            Console.WriteLine("Número é Ímpar");
        }
    }
    static void ex2()
    {
        Console.Write("Digite o primeiro número para a divisão: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número para a divisão: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultadoDivisao = Math.Round(num1 / num2, 3);
        Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");
    }
    static void ex3()
    {
        Console.Write("Digite um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 10)
        {
            Console.Beep();
            Console.WriteLine("Erro, valor maior do que o aceitável");
        }
        else
        {
            double resultado = numero * Math.PI;
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
    static void ex4()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void ex5()
    {
        int soma = 0;

        Console.WriteLine("Os primeiros 10 números naturais são:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros 10 números naturais é: {soma}");
    }
    static void ex6(int n)
    {
        int soma = 0;

        Console.WriteLine($"Os primeiros {n} números naturais são:");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros {n} números naturais é: {soma}");
    }
    static void ex7()
    {
        int soma = 0;

        Console.WriteLine("Os primeiros 10 números naturais são:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        double media = (double)soma / 10;

        Console.WriteLine($"A soma dos primeiros 10 números naturais é: {soma}");
        Console.WriteLine($"A média dos primeiros 10 números naturais é: {media}");
    }
    static void ex8(int n)
    {
        Console.WriteLine($"Os números e seus cubos até {n} termos são:");

        for (int i = 1; i <= n; i++)
        {
            int cubo = i * i * i;
            Console.WriteLine($"{i}^3 = {cubo}");
        }
    }
    static void ex9(int n)
    {
        Console.WriteLine($"Os cubos dos números até {n} termos são:");

        for (int i = 1; i <= n; i++)
        {
            int cubo = i * i * i;
            Console.WriteLine($"{i}^3 = {cubo}");
        }
    }
    static void ex10() {
        Random random = new Random();
        int n = random.Next(1, 101);

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");

        int tentativa;
        int tentativas= 0;

        do
        {
            Console.Write("Digite sua tentativa: ");
            if (int.TryParse(Console.ReadLine(), out tentativa))
            {
                tentativas++;

                if (tentativa == n)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativa(s).");
                }
                else if (tentativa < n)
                {
                    Console.WriteLine("Tente novamente. O número é maior.");
                }
                else
                {
                    Console.WriteLine("Tente novamente. O número é menor.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

        } while (tentativa != n);
    }
    static void ex11() {
        Console.Write("Digite a quantia em reais: ");

        if (decimal.TryParse(Console.ReadLine(), out decimal quantiaEmReais))
        {
            decimal taxaDeCambio = 5.5m;
            decimal quantiaEmDolares = quantiaEmReais / taxaDeCambio;

            Console.WriteLine($"O valor em dólares é: ${quantiaEmDolares:F2}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir um valor numérico.");
        }
    }
    static void ex12() {
        Console.Write("Digite um número: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine($"Tabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
        }
    }
    static void ex13() {
        Console.Write("Digite seu peso (em kg): ");

        if (double.TryParse(Console.ReadLine(), out double peso))
        {
            Console.Write("Digite sua altura (em metros): ");

            if (double.TryParse(Console.ReadLine(), out double altura))
            {
                double imc = peso / (altura * altura);
                Console.WriteLine($"Seu IMC é: {imc:F2}");
            }
            else
            {
                Console.WriteLine("Altura inválida. Certifique-se de inserir um valor numérico.");
            }
        }
        else
        {
            Console.WriteLine("Peso inválido. Certifique-se de inserir um valor numérico.");
        }
    }
    static bool ex14(int n) {
        if (n < 2)
        {
            return false; 
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static long ex15(int n) {
        if (n < 0)
        {
            throw new ArgumentException("O fatorial é indefinido para números negativos.");
        }
        long res= 1;
        for (int i = 2; i <= n; i++)
        {
            res*= i;
        }
        return res;
    }
}