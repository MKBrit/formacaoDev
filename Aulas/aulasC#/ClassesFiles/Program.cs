using ClassesFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Shop
{
    class Program
    { 
        static void Main(string[] args) 
        {
            //Criação de uma lista de produtos
            List<Produto> listaProdutos = new List<Produto>();

            //Adicionar produtos à lista
            Produto produto1 = new Produto(1, "Camisa", 29.99);
            listaProdutos.Add(produto1);

            Produto produto2 = new Produto(2, "Calças", 59.99);
            listaProdutos.Add(produto2);

            foreach (Produto produto in listaProdutos) 
            {
                produto.ImprimirDetalhes();
                Console.WriteLine();
            }

            Console.WriteLine("Total de Produtos: " + listaProdutos.Count);

            Produto produtoEncontrado = listaProdutos.Find(p => p.Nome == "Camisa");

            if (produtoEncontrado != null)
            {
                Console.WriteLine("Produto Encontrado: " + produtoEncontrado.Nome);
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }


            //Search by nome
            Console.WriteLine();
            Console.WriteLine("Introduza o produto a procurar: ");
            string userInput = Console.ReadLine();
            Produto search = listaProdutos.Find(p => p.Nome == userInput);

            if (search != null)
            {
                Console.WriteLine("Produto Encontrado: " + produtoEncontrado.Nome);
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }


            //Search by Id
            Console.WriteLine();
            Console.WriteLine("Introduza o id do produto a procurar: ");

            string userInput2 = Console.ReadLine();
            int.TryParse(userInput2, out int result);
            Produto search2 = listaProdutos.Find(p => p.Id == result);

            if (search2 != null)
            {
                Console.WriteLine("Produto Encontrado: " + produtoEncontrado.Nome);
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }


        }
    }
}