using System;

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
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            ex6(n);
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
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            ex8(n);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
                        }
                        break;

                    case 9:
                        Console.Write("Digite o número de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            ExibirCubos(n);
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
                        ex14();
                        break;

                    case 15:
                        ex1();
                        break;

                    default:
                        Console.WriteLine("ya dense...");
                        break;
                }
            }
        }

        //funções
    void ex1() {
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
    void ex2() {
        Console.Write("Digite o primeiro número para a divisão: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número para a divisão: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultadoDivisao = Math.Round(num1 / num2, 3);
        Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");
    }
    void ex3() {
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
    void ex4() {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    void ex5() {
        int soma = 0;

        Console.WriteLine("Os primeiros 10 números naturais são:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros 10 números naturais é: {soma}");
    }
    void ex6(int n) {
        int soma = 0;

        Console.WriteLine($"Os primeiros {nrs} números naturais são:");

        for (int i = 1; i <= nrs; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros {nrs} números naturais é: {soma}");
    }
    void ex7() {
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
    void ex8(int n) {
        Console.WriteLine($"Os números e seus cubos até {numeroDeTermos} termos são:");

        for (int i = 1; i <= numeroDeTermos; i++)
        {
            int cubo = i * i * i;
            Console.WriteLine($"{i}^3 = {cubo}");
        }
    }
    void ex9() {
        Console.WriteLine($"Os cubos dos números até {n} termos são:");

        for (int i = 1; i <= n; i++)
        {
            int cubo = cubo * cubo * cubo
            Console.WriteLine($"{i}^3 = {cubo}");
        }
    }
    void ex10() { }
    void ex11() { }
    void ex12() { }
    void ex13() { }
    void ex14() { }
    void ex15() { }
    }   