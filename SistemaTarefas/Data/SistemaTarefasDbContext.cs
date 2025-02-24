using Microsoft.EntityFrameworkCore;
using SistemaTarefas.Models;

namespace SistemaTarefas.Data
{
    public class SistemaTarefasDbContext : DbContext
    {
        public SistemaTarefasDbContext(DbContextOptions<SistemaTarefasDbContext> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Map.UsuarioMap());
            modelBuilder.ApplyConfiguration(new Map.TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
