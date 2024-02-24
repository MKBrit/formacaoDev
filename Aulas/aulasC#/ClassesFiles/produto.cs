using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFiles
{
    class Produto
    {

        public int Id;
        public string Nome;
        public double Preco;
         
        public Produto(int id, string nome, double preco) 
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preço: " + Preco);
        }

    }
}
