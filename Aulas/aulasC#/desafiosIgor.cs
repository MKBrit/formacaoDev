using System;

public class Totoloto
{
    public static void Main()
    {
        //main loop
        while (true)
        {
            Console.WriteLine("Escolha um exerc�cio");
            Console.WriteLine("1. Exerc�cio(Par/�mpar )");
            Console.WriteLine("2. Exerc�cio(Divis�o)");
            Console.WriteLine("3. Exerc�cio(Error on beep)");
            Console.WriteLine("4. Exerc�cio(Naturais 1)");
            Console.WriteLine("5. Exerc�cio(Naturais 2)");
            Console.WriteLine("6. Exerc�cio(Naturais 3)");
            Console.WriteLine("7. Exerc�cio(Naturais 4)");
            Console.WriteLine("8. Exerc�cio(Cubos 1)");
            Console.WriteLine("9. Exerc�cio(Cubos 2)");
            Console.WriteLine("10. Exerc�cio(Guess)");
            Console.WriteLine("11. Exerc�cio(Conversor)");
            Console.WriteLine("12. Exerc�cio(Tabuada)");
            Console.WriteLine("13. Exerc�cio(IMC)");
            Console.WriteLine("14. Exerc�cio(Primos)");
            Console.WriteLine("15. Exerc�cio(Fatorial)");
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
                        Console.Write("Digite o n�mero de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            ex6(n);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inv�lida. Certifique-se de inserir um n�mero inteiro.");
                        }
                        break;

                    case 7:
                        ex7();
                        break;

                    case 8:
                        Console.Write("Digite o n�mero de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            ex8(n);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inv�lida. Certifique-se de inserir um n�mero inteiro.");
                        }
                        break;

                    case 9:
                        Console.Write("Digite o n�mero de termos desejados: ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            ExibirCubos(n);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inv�lida. Certifique-se de inserir um n�mero inteiro.");
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

        //fun��es
    void ex1() {
        Console.Write("Digite o primeiro n�mero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo n�mero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        Console.WriteLine($"A soma dos n�meros �: {soma}");

        if (soma % 2 != 0)
        {
            Console.WriteLine("N�mero � �mpar");
        }
    }
    void ex2() {
        Console.Write("Digite o primeiro n�mero para a divis�o: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo n�mero para a divis�o: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultadoDivisao = Math.Round(num1 / num2, 3);
        Console.WriteLine($"Resultado da divis�o: {resultadoDivisao}");
    }
    void ex3() {
        Console.Write("Digite um n�mero: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 10)
        {
            Console.Beep();
            Console.WriteLine("Erro, valor maior do que o aceit�vel");
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

        Console.WriteLine("Os primeiros 10 n�meros naturais s�o:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros 10 n�meros naturais �: {soma}");
    }
    void ex6(int n) {
        int soma = 0;

        Console.WriteLine($"Os primeiros {nrs} n�meros naturais s�o:");

        for (int i = 1; i <= nrs; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros {nrs} n�meros naturais �: {soma}");
    }
    void ex7() {
        int soma = 0;

        Console.WriteLine("Os primeiros 10 n�meros naturais s�o:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        double media = (double)soma / 10;

        Console.WriteLine($"A soma dos primeiros 10 n�meros naturais �: {soma}");
        Console.WriteLine($"A m�dia dos primeiros 10 n�meros naturais �: {media}");
    }
    void ex8(int n) {
        Console.WriteLine($"Os n�meros e seus cubos at� {numeroDeTermos} termos s�o:");

        for (int i = 1; i <= numeroDeTermos; i++)
        {
            int cubo = i * i * i;
            Console.WriteLine($"{i}^3 = {cubo}");
        }
    }
    void ex9() {
        Console.WriteLine($"Os cubos dos n�meros at� {n} termos s�o:");

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