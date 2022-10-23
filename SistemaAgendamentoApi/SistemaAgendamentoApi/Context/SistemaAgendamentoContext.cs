using Microsoft.EntityFrameworkCore;
using SistemaAgendamentoApi.Models;

namespace SistemaAgendamentoApi.Context;

public class SistemaAgendamentoContext: DbContext
{
    public SistemaAgendamentoContext(DbContextOptions<SistemaAgendamentoContext> options) : base(options)
    {
    }
    
    public DbSet<Tarefa> Tarefas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>()
            .Property(b => b.Data).HasDefaultValue(DateTime.Now);
    }
    
    
}