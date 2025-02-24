using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTarefas.Models;

namespace SistemaTarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Status).IsRequired();

            builder.Property(p => p.UsuarioId);
            builder.HasOne(p => p.Usuario);
        }
    }
}
