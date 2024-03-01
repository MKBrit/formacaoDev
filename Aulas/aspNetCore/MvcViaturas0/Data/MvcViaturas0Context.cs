using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcViaturas0;

namespace MvcViaturas0.Data
{
    public class MvcViaturas0Context : DbContext
    {
        public MvcViaturas0Context (DbContextOptions<MvcViaturas0Context> options)
            : base(options)
        {
        }

        public DbSet<MvcViaturas0.Viatura> Viatura { get; set; } = default!;
    }
}
