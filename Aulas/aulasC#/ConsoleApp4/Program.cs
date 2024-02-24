using System;
using System.Runtime;

namespace MateriaAula
{
    class Program
    {
        public class Animal
        {
            public virtual void Comer()
            {
                Console.WriteLine("Sou um animal e estou a comer");
            }

            public void Lavar()
            {
                Console.WriteLine("Sou um animal e estou a lavar-me");
            }
        }

        public class Cao : Animal
        {
            public override void Comer()
            {
                Console.WriteLine("Sou um cão e estou a comer");
            }

            public void Ladrar()
            {
                Console.WriteLine("Sou um cao e ladro"); }

        }

        public class PastorA : Cao 
        {
            public void ChamarPastorA()
            {
                Console.WriteLine("Chamar Alemão");
            }
        }


        public class Gato : Animal
        {
            public override void Comer()
            {
                Console.WriteLine("Sou um gato estou a comer");
            }

            public void Miar()
            { 
                Console.WriteLine("Sou um gato estou miar");
            }
        }

        static void Main(string[] args) 
        { 
            Animal animal = new Animal();
            animal.Comer();
            animal.Lavar();

            
            Cao cao = new Cao();
            cao.Comer();
            cao.Lavar();
            cao.Ladrar();

            PastorA alemao = new PastorA();
            alemao.ChamarPastorA();

            Gato gato = new Gato();
            gato.Comer();
            gato.Lavar();
            gato.Miar();
        
        }
    }
}