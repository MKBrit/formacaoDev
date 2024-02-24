using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13Dez
{    class Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public bool EstaEmprestado;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            EstaEmprestado = false;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = DateTime.Now.Year;
            EstaEmprestado = false;
        }

        public void Emprestar()
        {
            if (EstaEmprestado == true) 
            {
                Console.WriteLine("O livro já está emprestado!");
            }
            else 
            {
                EstaEmprestado = true;
                Console.WriteLine("O livro foi emprestado com sucesso!");
            }
        }

        public void Devolver()
        {
            if (EstaEmprestado == true)
            {
                Console.WriteLine("Livro reposto com sucesso!");
            }
            else
            {
                EstaEmprestado = false;
                Console.WriteLine("O livro já está disponível na biblioteca!");
            }
        }

        public override string ToString()
        {
            //Console.WriteLine(meuLivro); = //Console.WriteLine(meuLivro.ToString());
            // o metodo toString esta incluido auto, so we override it

            return $"Livro: {Titulo} - Autor: {Autor} - Ano Publicação: {AnoPublicacao}";
        }
    }
}
