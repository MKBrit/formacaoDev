using System;

public class Totoloto
{
    public static void Main()
    {

        /* 
        1.  For, While e Do...While Loops
        2.  Um For é um loop que tipicamente percorre um certo número de iterações definidas pelo dev, normalmente incrementando a cada iteração até chegar ao final pretendido;
            Um While é quase um ciclo infinito, pelo menos "enquanto" precisamos que o seja. Utilizamos para manter o programa "On" ou num certo passo, até uma condição ser encontrada;
            Um Do..While, praticamente igual, mas nesta situação, o compiler irá sempre fazer o conteúdo do "Do" antes de verificar se a condição do "While" (lingua nativa deu branca) 
"is met", e por sua vez executar o ciclo "While" (eu este raramente uso este, portanto tenho quase a certeza absoluta que é isto, mas posso ter confundido um passo qql)
        3.  Eu uso um for loop, quando preciso de percorrer algo um certo nr de vezes (listas/arrays/vectores/ficheiros/etc) ou seja, se eu precisar de fazer a mesma ação n vezes, 
então uso um for loop
        4.  Então será o contador/posição, a range, e o incremento. O contador será o nr da iteração (0,1,2,3....), a range é o .... é a range tipo.... -.- ....até onde ele vai, 
ou limite, ou o fim do ciclo. O incremento, vai alterar o valor do contador a cada iteração, normalmente acrescentando ou diminuindo dependendo da situação;
        5.  Através de contadores e incrementos;
        6.  Sempre que preciso de ações enquanto uma condição "is met", seja 0 vezes, 1 vez, ou 1E9 vezes, o exemplo mais comum, será o menu principal;
        7.  Sempre que queremos que o programa execute algo pelo menos uma vez antes de verificar se a condição "is met" (nao me lembro do termo pt-pt.....);
        8.  Possivelmente o programa ignora o conteudo do ciclo While, invés do Do While que irá sempre fazer as ações do "Do" 1x, e repetirá caso as condições sejam encontradas (vês não soa bem :/ );
        9.  Com a utilização de flags, ou failsafes;
        10. Caso eu precise de ler/escrever o conteúdo de/em um txt, usaria um for loop para percorrer cada linha

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        1.  Receber input do utilizador
        2.  Crio uma variável, e aponto o input para essa variável por exemplo: int variavel = Console.ReadLine();
        3.  Ok, portanto os argumentos são as variáveis que queremos passar para a função/método quando a chamamos, e os parâmetros são... pera what?? <.< a mesma coisa, mas... estou confuso agora...
ou seja os argumentos sao os parametros que a função vai receber....... qd chamamos a função enviamos-lhe argumentos, quando estamos na função, ela usa os parâmetros que recebe....... olha não sei  O.o
        4.  "tipo de variavel" + "nomeFunção" + "(argumentos)" + "{conteúdo}"   por exemplo:    void funcaoExemplo(int valor){"conteúdo"};
        5.  Void significa vazio, ou seja nao tem retorno porque não tem definido um tipo de variável para retornar (int, float, bool, etc...) ao contrário de uma funcao int(integer) que devolve um inteiro;
        6.  Chamamos pelo nome dela :D  por exemplo: funcaoExemplo(x)
        7.  Porque conseguimos automatizar processos e não os repetir vezes vezes sem conta o mesmo código;
        8.  Será o conceito de módulos? Ou seja dividimos o código por blocos ou criamos código em blocos, que podem ser sempre reutilizados noutros projetos, trazendo organização ao código e clareza;
        9.  Ajuda bastante no desenvolvimento do código seja a solo ou em grupo, como também na manutenção e atualização do código. No fundo cada macaco no seu galho.
        10. Se eu quiser criar um programa que converta Celsius em Farenheit, ou milhas em kilometros, eu criava uma função para cada uma dessas conversões.
         */
        while (true)
        {
            Console.WriteLine("Escolha o exercício");
            Console.WriteLine("1. For loop");
            Console.WriteLine("2. While loop");
            Console.WriteLine("3. Do...While loop");
            Console.WriteLine("4. BemVindo user");
            Console.WriteLine("5. Soma de ints");
            Console.WriteLine("6. Argumento x2")
            Console.WriteLine("7. Cº to Farenheit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                double result;
                switch (choice)
                {
                    case 1:
                        forLoop();
                        break;

                    case 2:
                        whileLoop();
                        break;

                    case 3:
                        doWhileLoop();
                        break;

                    case 4:
                        BemVindo();
                        break;

                    case 5:
                        soma();
                        break;

                    case 6:
                        Console.Write("Introduza um número: ");
                        if (double.TryParse(Console.ReadLine(), out double number))
                        {
                            result = doubleArgument(number);
                            Console.WriteLine($"O dobro do número é: {result}");
                        }
                        else
                        {
                            Console.WriteLine("ya dense...");
                        }
                        break;


                    case 7:
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


    static void forLoop()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} ");
        }
    }


    static void whileLoop()
    {
        int x = 10;
        int y = 1;
        while ( x >= y) 
        {
            Console.WriteLine($"{y} ");
            y += 1;
        }
    }


    static void doWhileLoop()
    {
        int i = 1;
        do
        {
            Console.WriteLine($"{i} ");
            i++;
        } while (i <= 10);
    }


    static void BemVindo()
    {
        Console.Write("Introduza o seu nome: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Bem-vindo, {userName}!");
    }


    static void soma()
    {
        Console.Write("Introduza o primeiro número inteiro: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.Write("Introduza o segundo número inteiro: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                int sum = num1 + num2;
                Console.WriteLine($"A soma dos números é: {sum}");
            }
            else
            {
                Console.WriteLine("Entrada inválida...");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida...");
        }
    }


    static double doubleArgument(double number)
    {
        return number * 2;
    }


    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

}