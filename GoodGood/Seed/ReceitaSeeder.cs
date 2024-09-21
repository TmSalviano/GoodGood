using GoodGood.Data;
using GoodGood.Models;
using Microsoft.EntityFrameworkCore;

public class ReceitaSeeder {
    public static async Task Seed1ItemAsync(IServiceProvider serviceProvider) {

        using (var dbContext = new ComidaDbContext(serviceProvider.GetRequiredService<DbContextOptions<ComidaDbContext>>()))
        {
            if (dbContext.Ingredientes.Any())  {
                return;
            }

            var ingrediente1 = new Ingrediente() {
                Id = 1,
                Name = "Ingrediente1",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                GordurasEmG = 0,
                ProteinasEmG = 0,
                UnidadeDeMedida = new List<string> { "Unidade1", "Unidade2", "Unidade3",}
            };

            var ingrediente2 = new Ingrediente() {
                Id = 2,
                Name = "Ingrediente2",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                GordurasEmG = 0,
                ProteinasEmG = 0,
                UnidadeDeMedida = new List<string> { "Unidade1", "Unidade2", "Unidade3",}
            };

            await dbContext.Ingredientes.AddRangeAsync([ingrediente1, ingrediente2]);
            await dbContext.SaveChangesAsync();


            if (dbContext.Receitas.Any()) {
                return;
            }

            var receita = new Receita {
                Nome = "Cake",
                Categoria1 = "Dessert",
                Categoria2 = "Sweets",
                ModeDePreparo = new List<string> { "Mix ingredients", "Bake at 180C" },
                IngredientesDaReceita = new List<ReceitaIngrediente> {
                    new ReceitaIngrediente { IngredienteId = 1, Quantidade = 3 }, // e.g., 200g flour
                    new ReceitaIngrediente { IngredienteId = 2, Quantidade = 2 }  // e.g., 100g sugar
                }
            };

            await dbContext.Receitas.AddAsync(receita);
            await dbContext.SaveChangesAsync();
        }
    }
}