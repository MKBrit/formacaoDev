using System;

delegate int NumberChanger(int n);

namespace Explicacoes
{
    class TestDelegate
    {
        static int num = 10;
        public static int Addnum(int p)
        {
            num += p;
            return num;
        }
        public static int Multnum(int q)
        { 
            num *= q;
            return num;
        }
        public static int Getnum() 
        { 
            return num;
        }


        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(Addnum);
            NumberChanger nc2 = new NumberChanger(Multnum);

            nc1(25);
            Console.WriteLine("Valor do nr: {0}", Getnum());
            nc2(5);
            Console.WriteLine("Valor de nr: {0}", Getnum());
            Console.ReadKey();
        }
    }
}