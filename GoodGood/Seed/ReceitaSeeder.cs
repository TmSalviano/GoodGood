using GoodGood.Data;
using GoodGood.Models;
using Microsoft.EntityFrameworkCore;

public class ReceitaSeeder {
    public static async Task SeedComidaDb(IServiceProvider serviceProvider) {

        using (var dbContext = new ComidaDbContext(serviceProvider.GetRequiredService<DbContextOptions<ComidaDbContext>>()))
        {
          await SeedIngredientDbSet(dbContext);
          await SeedReceitaDbSet(dbContext);
        }
    }

    private static async Task SeedIngredientDbSet(ComidaDbContext dbContext) {
        if (dbContext.Ingredientes.Any())  {
                return;
            }

            var ingredientes = new List<Ingrediente>(){
                new Ingrediente() {
                    Id = 1,
                    Name = "Morango",
                    CaloriasEmKcal = 20,
                    CarboidratosEmG = 5,
                    GordurasEmG = 0.2f,
                    ProteinasEmG = 0.4f,
                    UnidadeDeMedida = new List<string> { "unidades(60g)",}
                },

               new Ingrediente() {
                    Id = 2,
                    Name = "Ingrediente2",
                    CaloriasEmKcal = 0,
                    CarboidratosEmG = 0,
                    GordurasEmG = 0,
                    ProteinasEmG = 0,
                    UnidadeDeMedida = new List<string> { "Unidade1",}
                },

                new Ingrediente() {
                    Id = 1,
                    Name = "Ingrediente1",
                    CaloriasEmKcal = 0,
                    CarboidratosEmG = 0,
                    GordurasEmG = 0,
                    
                    ProteinasEmG = 0,
                    UnidadeDeMedida = new List<string> { "Unidade1",}
                },
            };


        await dbContext.Ingredientes.AddRangeAsync(ingredientes);
        await dbContext.SaveChangesAsync();
    }

    private static async Task SeedReceitaDbSet(ComidaDbContext dbContext) {
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
