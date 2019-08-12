using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Otamix1.Models;

namespace Otamix1.Models
{
    public class Otamix1Context : DbContext
    {
        public Otamix1Context (DbContextOptions<Otamix1Context> options)
            : base(options)
        {
        }

        public DbSet<Otamix1.Models.Mensagem> Mensagem { get; set; }

        public DbSet<Otamix1.Models.Descricao> Descricao { get; set; }

        public DbSet<Otamix1.Models.Comentario> Comentario { get; set; }

        public DbSet<Otamix1.Models.Categoria> Categoria { get; set; }
    }
}
