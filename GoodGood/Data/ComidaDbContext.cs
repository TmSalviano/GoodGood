

using GoodGood.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodGood.Data {
    public class ComidaDbContext : DbContext {
        public ComidaDbContext(DbContextOptions<ComidaDbContext> options) : base (options) { }

        public DbSet<Receita> Receitas{ get; set; } = default!;
        public DbSet<Ingrediente> Ingredientes{ get; set; } = default!;
        public DbSet<ReceitaIngrediente> ReceitasIngrediente{ get; set;} = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // Configuring the many-to-many relationship between Receita and Ingrediente
        modelBuilder.Entity<ReceitaIngrediente>()
            .HasKey(ri => new { ri.ReceitaId, ri.IngredienteId });

        modelBuilder.Entity<ReceitaIngrediente>()
            .HasOne(ri => ri.Receita)
            .WithMany(r => r.IngredientesDaReceita)
            .HasForeignKey(ri => ri.ReceitaId);

        modelBuilder.Entity<ReceitaIngrediente>()
            .HasOne(ri => ri.Ingrediente)
            .WithMany()
            .HasForeignKey(ri => ri.IngredienteId);
    }
    }
}