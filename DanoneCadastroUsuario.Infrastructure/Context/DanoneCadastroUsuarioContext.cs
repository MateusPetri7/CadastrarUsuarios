using DanoneCadastroUsuario.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanoneCadastroUsuario.Infrastructure.Context
{
    public class DanoneCadastroUsuarioContext : DbContext
    {
        public DanoneCadastroUsuarioContext(DbContextOptions options) : base(options) { }
        public DbSet<DanoneUsuarioEntity> DanoneUsuarioEntity { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
