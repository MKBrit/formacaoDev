using System;

public class Totoloto
{
    public static void Main()
    {

        /* 
        1.  For, While e Do...While Loops
        2.  Um For � um loop que tipicamente percorre um certo n�mero de itera��es definidas pelo dev, normalmente incrementando a cada itera��o at� chegar ao final pretendido;
            Um While � quase um ciclo infinito, pelo menos "enquanto" precisamos que o seja. Utilizamos para manter o programa "On" ou num certo passo, at� uma condi��o ser encontrada;
            Um Do..While, praticamente igual, mas nesta situa��o, o compiler ir� sempre fazer o conte�do do "Do" antes de verificar se a condi��o do "While" (lingua nativa deu branca) 
"is met", e por sua vez executar o ciclo "While" (eu este raramente uso este, portanto tenho quase a certeza absoluta que � isto, mas posso ter confundido um passo qql)
        3.  Eu uso um for loop, quando preciso de percorrer algo um certo nr de vezes (listas/arrays/vectores/ficheiros/etc) ou seja, se eu precisar de fazer a mesma a��o n vezes, 
ent�o uso um for loop
        4.  Ent�o ser� o contador/posi��o, a range, e o incremento. O contador ser� o nr da itera��o (0,1,2,3....), a range � o .... � a range tipo.... -.- ....at� onde ele vai, 
ou limite, ou o fim do ciclo. O incremento, vai alterar o valor do contador a cada itera��o, normalmente acrescentando ou diminuindo dependendo da situa��o;
        5.  Atrav�s de contadores e incrementos;
        6.  Sempre que preciso de a��es enquanto uma condi��o "is met", seja 0 vezes, 1 vez, ou 1E9 vezes, o exemplo mais comum, ser� o menu principal;
        7.  Sempre que queremos que o programa execute algo pelo menos uma vez antes de verificar se a condi��o "is met" (nao me lembro do termo pt-pt.....);
        8.  Possivelmente o programa ignora o conteudo do ciclo While, inv�s do Do While que ir� sempre fazer as a��es do "Do" 1x, e repetir� caso as condi��es sejam encontradas (v�s n�o soa bem :/ );
        9.  Com a utiliza��o de flags, ou failsafes;
        10. Caso eu precise de ler/escrever o conte�do de/em um txt, usaria um for loop para percorrer cada linha

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        1.  Receber input do utilizador
        2.  Crio uma vari�vel, e aponto o input para essa vari�vel por exemplo: int variavel = Console.ReadLine();
        3.  Ok, portanto os argumentos s�o as vari�veis que queremos passar para a fun��o/m�todo quando a chamamos, e os par�metros s�o... pera what?? <.< a mesma coisa, mas... estou confuso agora...
ou seja os argumentos sao os parametros que a fun��o vai receber....... qd chamamos a fun��o enviamos-lhe argumentos, quando estamos na fun��o, ela usa os par�metros que recebe....... olha n�o sei  O.o
        4.  "tipo de variavel" + "nomeFun��o" + "(argumentos)" + "{conte�do}"   por exemplo:    void funcaoExemplo(int valor){"conte�do"};
        5.  Void significa vazio, ou seja nao tem retorno porque n�o tem definido um tipo de vari�vel para retornar (int, float, bool, etc...) ao contr�rio de uma funcao int(integer) que devolve um inteiro;
        6.  Chamamos pelo nome dela :D  por exemplo: funcaoExemplo(x)
        7.  Porque conseguimos automatizar processos e n�o os repetir vezes vezes sem conta o mesmo c�digo;
        8.  Ser� o conceito de m�dulos? Ou seja dividimos o c�digo por blocos ou criamos c�digo em blocos, que podem ser sempre reutilizados noutros projetos, trazendo organiza��o ao c�digo e clareza;
        9.  Ajuda bastante no desenvolvimento do c�digo seja a solo ou em grupo, como tamb�m na manuten��o e atualiza��o do c�digo. No fundo cada macaco no seu galho.
        10. Se eu quiser criar um programa que converta Celsius em Farenheit, ou milhas em kilometros, eu criava uma fun��o para cada uma dessas convers�es.
         */
        while (true)
        {
            Console.WriteLine("Escolha o exerc�cio");
            Console.WriteLine("1. For loop");
            Console.WriteLine("2. While loop");
            Console.WriteLine("3. Do...While loop");
            Console.WriteLine("4. BemVindo user");
            Console.WriteLine("5. Soma de ints");
            Console.WriteLine("6. Argumento x2")
            Console.WriteLine("7. C� to Farenheit");

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
                        Console.Write("Introduza um n�mero: ");
                        if (double.TryParse(Console.ReadLine(), out double number))
                        {
                            result = doubleArgument(number);
                            Console.WriteLine($"O dobro do n�mero �: {result}");
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
        Console.Write("Introduza o primeiro n�mero inteiro: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.Write("Introduza o segundo n�mero inteiro: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                int sum = num1 + num2;
                Console.WriteLine($"A soma dos n�meros �: {sum}");
            }
            else
            {
                Console.WriteLine("Entrada inv�lida...");
            }
        }
        else
        {
            Console.WriteLine("Entrada inv�lida...");
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