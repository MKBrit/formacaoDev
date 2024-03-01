using Microsoft.EntityFrameworkCore;
using MvcLivros.Data;
using MvcLivros.Models;

namespace MvcLivro.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcLivrosContext(serviceProvider.GetRequiredService<DbContextOptions<MvcLivrosContext>>()))
            {
                // Procura na bd se já existem livros
                if (context.Livro.Any())
                {
                    return;
                    // Se a bd já tiver dados não faz nada
                }
                //caso contrário adiciona dados de teste
                context.Livro.AddRange(
                    new Livro
                    {
                        Titulo = "Sql para tótós",
                        DataLancamento = DateTime.Parse("2001-2-12"),
                        Genere = "Base de dados",
                        Preco = 7.99M
                    },
                        new Livro
                        {
                            Titulo = "Fundamentos  Ruby",
                            DataLancamento = DateTime.Parse("2010-3-13"),
                            Genere = "Programação",
                            Preco = 8.99M
                        },

            new Livro
            {
                Titulo = "Scripting em Linux",
                DataLancamento = DateTime.Parse("1998-2-23"),
                Genere = "Linux",
                Preco = 9.99M
            },
                new Livro
                {
                    Titulo = "Cibersegurança fundamentos",
                    DataLancamento = DateTime.Parse("2020-4-15"),
                    Genere = "Web",
                    Preco = 3.99M
                }
            );
                context.SaveChanges();
            }
        }
    }
}
