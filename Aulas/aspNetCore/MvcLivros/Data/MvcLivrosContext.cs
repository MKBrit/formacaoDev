using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcLivros.Models;

namespace MvcLivros.Data
{
    public class MvcLivrosContext : DbContext
    {
        public MvcLivrosContext (DbContextOptions<MvcLivrosContext> options)
            : base(options)
        {
        }

        public DbSet<MvcLivros.Models.Livro> Livro { get; set; } = default!;
    }
}
