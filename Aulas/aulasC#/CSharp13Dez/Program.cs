using CSharp13Dez;
using Microsoft.Win32;
using System;

namespace biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar novo objecto "Livro" by construtor
            Livro meuLivro = new Livro("Os Mais", "Eça de Queiros", 1994);
            Livro meuLivro2 = new Livro("C#, Ai Terrori!", "Igor Lima", 1988);
            Livro meuLivro3 = new Livro("Os Lusíadas", "Luís de Camões");


            // Aceder  propriedade do livro
            Console.WriteLine("Titulo: " + meuLivro.Titulo);
            Console.WriteLine("Autor: "+ meuLivro.Autor);
            Console.WriteLine("Ano Publicação: " + meuLivro.AnoPublicacao);
            Console.WriteLine();

            Console.WriteLine("Titulo: " + meuLivro2.Titulo);
            Console.WriteLine("Autor: " + meuLivro2.Autor);
            Console.WriteLine("Ano Publicação: " + meuLivro2.AnoPublicacao);
            Console.WriteLine();

            Console.WriteLine("Titulo: " + meuLivro3.Titulo);
            Console.WriteLine("Autor: " + meuLivro3.Autor);
            Console.WriteLine("Ano Publicação: " + meuLivro3.AnoPublicacao);
            Console.WriteLine();

            meuLivro.Emprestar();
            meuLivro.Devolver();


            Console.WriteLine(meuLivro);
        }
    }
}