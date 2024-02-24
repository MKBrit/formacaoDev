using System;

namespace ClassesAbst
{
    class Program
    { 
        static void Main(string[] args) 
        {
            Cao cao = new Cao();
            cao.Comer();
            cao.valor++;

            Gato gato = new Gato();
            gato.Comer();
            gato.valor++;
        }
    }


    abstract class Animal
    {
        public int valor;

        public abstract string Comer();

    }

    class Cao : Animal 
    {
        public override string Comer()
        {
            return "Sou um cão";
        }
    }

    class Gato : Animal
    {
        public override string Comer()
        {
            return "Sou um gato";
        }
    }



}