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
                    Name = "Morangos",
                    CaloriasEmKcal = 20,
                    CarboidratosEmG = 5,
                    ProteinasEmG = 0.4f,
                    GordurasEmG = 0.2f,
                    UnidadeDeMedida = new List<string> { "unidades (60g)" }
                },

                new Ingrediente() {
                    Id = 2,
                    Name = "Chia",
                    CaloriasEmKcal = 400,
                    CarboidratosEmG = 34,
                    ProteinasEmG = 14,
                    GordurasEmG = 28,
                    UnidadeDeMedida = new List<string> { "xícara (80g)" }
                },

                new Ingrediente() {
                    Id = 3,
                    Name = "Chocolate meio amargo",
                    CaloriasEmKcal = 2400,
                    CarboidratosEmG = 240,
                    ProteinasEmG = 24,
                    GordurasEmG = 135,
                    UnidadeDeMedida = new List<string> { "g" }
                },

                new Ingrediente() {
                    Id = 4,
                    Name = "Cenoura",
                    CaloriasEmKcal = 12,
                    CarboidratosEmG = 3,
                    ProteinasEmG = 0.3f,
                    GordurasEmG = 0.1f,
                    UnidadeDeMedida = new List<string> { "xícara (30g)" }
                },

                new Ingrediente() {
                    Id = 5,
                    Name = "Milho cozido",
                    CaloriasEmKcal = 36,
                    CarboidratosEmG = 8,
                    ProteinasEmG = 1,
                    GordurasEmG = 0.5f,
                    UnidadeDeMedida = new List<string> { "xícara (40g)" }
                },

                new Ingrediente() {
                    Id = 6,
                    Name = "Ervilha",
                    CaloriasEmKcal = 34,
                    CarboidratosEmG = 6,
                    ProteinasEmG = 2,
                    GordurasEmG = 0.2f,
                    UnidadeDeMedida = new List<string> { "xícara (40g)" }
                },
                new Ingrediente() {
                    Id = 7,
                    Name = "Ovos",
                    CaloriasEmKcal = 192,
                    CarboidratosEmG = 2,
                    ProteinasEmG = 12,
                    GordurasEmG = 14,
                    UnidadeDeMedida = new List<string> { "unidades (136g)" }
                },

                new Ingrediente() {
                    Id = 8,
                    Name = "Azeite",
                    CaloriasEmKcal = 45,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 5,
                    UnidadeDeMedida = new List<string> { "fio (5g)" }
                },
                new Ingrediente() {
                    Id = 9,
                    Name = "Cebola",
                    CaloriasEmKcal = 10,
                    CarboidratosEmG = 2,
                    ProteinasEmG = 0.3f,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "cebola média (25g)" }
                },

                new Ingrediente() {
                    Id = 10,
                    Name = "Maizena",
                    CaloriasEmKcal = 110,
                    CarboidratosEmG = 30,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
                },

                new Ingrediente() {
                    Id = 11,
                    Name = "Água",
                    CaloriasEmKcal = 0,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "xícaras (480g)" }
                },

                new Ingrediente() {
                    Id = 12,
                    Name = "Aveia",
                    CaloriasEmKcal = 114,
                    CarboidratosEmG = 19,
                    ProteinasEmG = 4,
                    GordurasEmG = 2,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
                },
                new Ingrediente() {
                    Id = 13,
                    Name = "Iogurte grego sem gordura",
                    CaloriasEmKcal = 120,
                    CarboidratosEmG = 6,
                    ProteinasEmG = 22,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "xícara (245g)" }
                },

                new Ingrediente() {
                    Id = 14,
                    Name = "Café instantâneo",
                    CaloriasEmKcal = 0,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colheres de café (3g)" }
                },

                new Ingrediente() {
                    Id = 15,
                    Name = "Leite",
                    CaloriasEmKcal = 30,
                    CarboidratosEmG = 3,
                    ProteinasEmG = 2,
                    GordurasEmG = 1,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (60g)" }
                },

                new Ingrediente() {
                    Id = 16,
                    Name = "Mel",
                    CaloriasEmKcal = 64,
                    CarboidratosEmG = 17,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colher de sopa (21g)" }
                },

                new Ingrediente() {
                    Id = 18,
                    Name = "Whey protein",
                    CaloriasEmKcal = 100,
                    CarboidratosEmG = 2,
                    ProteinasEmG = 20,
                    GordurasEmG = 1,
                    UnidadeDeMedida = new List<string> { "g (25g)" }
                },


                new Ingrediente() {
                    Id = 12,
                    Name = "Aveia",
                    CaloriasEmKcal = 114,
                    CarboidratosEmG = 19,
                    ProteinasEmG = 4,
                    GordurasEmG = 2,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
                },
                new Ingrediente() {
                    Id = 21,
                    Name = "Whey protein",
                    CaloriasEmKcal = 240,
                    CarboidratosEmG = 4,
                    ProteinasEmG = 48,
                    GordurasEmG = 2,
                    UnidadeDeMedida = new List<string> { "g (60g)" }
                },

                new Ingrediente() {
                    Id = 22,
                    Name = "Açúcar de stevia marrom",
                    CaloriasEmKcal = 0,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "g (50g)" }
                },

                new Ingrediente() {
                    Id = 23,
                    Name = "Canela",
                    CaloriasEmKcal = 24,
                    CarboidratosEmG = 6,
                    ProteinasEmG = 0.6f,
                    GordurasEmG = 0.1f,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (12g)" }
                },

                new Ingrediente() {
                    Id = 24,
                    Name = "Fermento em pó",
                    CaloriasEmKcal = 5,
                    CarboidratosEmG = 1,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colher de sopa (10g)" }
                },

                new Ingrediente() {
                    Id = 25,
                    Name = "Leite desnatado",
                    CaloriasEmKcal = 180,
                    CarboidratosEmG = 24,
                    ProteinasEmG = 16,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "ml (480ml)" }
                },


                new Ingrediente() {
                    Id = 27,
                    Name = "Maçãs",
                    CaloriasEmKcal = 312,
                    CarboidratosEmG = 84,
                    ProteinasEmG = 0.6f,
                    GordurasEmG = 0.6f,
                    UnidadeDeMedida = new List<string> { "unidades (600g)" }
                },

                new Ingrediente() {
                    Id = 28,
                    Name = "Manteiga",
                    CaloriasEmKcal = 107,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 12,
                    UnidadeDeMedida = new List<string> { "g (15g)" }
                },

                new Ingrediente() {
                    Id = 29,
                    Name = "Gelatina de morango sem açúcar",
                    CaloriasEmKcal = 10,
                    CarboidratosEmG = 2,
                    ProteinasEmG = 2,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "pacote (85g)" }
                },

                new Ingrediente() {
                    Id = 30,
                    Name = "Iogurte grego",
                    CaloriasEmKcal = 130,
                    CarboidratosEmG = 7,
                    ProteinasEmG = 25,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "g (290g)" }
                },

                new Ingrediente() {
                    Id = 31,
                    Name = "Whey protein sem sabor",
                    CaloriasEmKcal = 120,
                    CarboidratosEmG = 2,
                    ProteinasEmG = 24,
                    GordurasEmG = 1,
                    UnidadeDeMedida = new List<string> { "g (30g)" }
                },

            new Ingrediente() {
                    Id = 8,
                    Name = "Azeite",
                    CaloriasEmKcal = 45,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 5,
                    UnidadeDeMedida = new List<string> { "fio (5g)" }
                },
            new Ingrediente() {
                Id = 34,
                Name = "Páprica defumada",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 1.3f,
                ProteinasEmG = 0.3f,
                GordurasEmG = 0.3f,
                UnidadeDeMedida = new List<string> { "colher de sopa (2 g)" }
            },

            new Ingrediente() {
                Id = 35,
                Name = "Tomilho seco",
                CaloriasEmKcal = 3,
                CarboidratosEmG = 0.7f,
                ProteinasEmG = 0.1f,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de chá (1 g)" }
            },

            new Ingrediente() {
                Id = 36,
                Name = "Frango cozido desfiado",
                CaloriasEmKcal = 165,
                CarboidratosEmG = 0,
                ProteinasEmG = 31,
                GordurasEmG = 3.6f,
                UnidadeDeMedida = new List<string> { "g (150 g)" }
            },

            new Ingrediente() {
                Id = 37,
                Name = "Cebolinha",
                CaloriasEmKcal = 5,
                CarboidratosEmG = 1.2f,
                ProteinasEmG = 0.3f,
                GordurasEmG = 0.1f,
                UnidadeDeMedida = new List<string> { "a gosto" }
            },

            new Ingrediente() {
                Id = 38,
                Name = "Fermento em pó",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 1.5f,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de sopa (5 g)" }
            },

            new Ingrediente() {
                Id = 39,
                Name = "Tomate-cereja",
                CaloriasEmKcal = 18,
                CarboidratosEmG = 3.9f,
                ProteinasEmG = 0.9f,
                GordurasEmG = 0.2f,
                UnidadeDeMedida = new List<string> { "a gosto (100 g)" }
            },

            new Ingrediente() {
                Id = 40,
                Name = "Alecrim",
                CaloriasEmKcal = 1,
                CarboidratosEmG = 0.2f,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "a gosto" }
            },

            new Ingrediente() {
                Id = 41,
                Name = "Ovo",
                CaloriasEmKcal = 68,
                CarboidratosEmG = 0.6f,
                ProteinasEmG = 6,
                GordurasEmG = 4.8f,
                UnidadeDeMedida = new List<string> { "unidade (68g)" }
            },

            new Ingrediente() {
                Id = 42,
                Name = "Farinha sem fermento",
                CaloriasEmKcal = 146,
                CarboidratosEmG = 30,
                ProteinasEmG = 4,
                GordurasEmG = 0.4f,
                UnidadeDeMedida = new List<string> { "g (40g)" }
            },

            new Ingrediente() {
                Id = 43,
                Name = "Iogurte grego",
                CaloriasEmKcal = 52,
                CarboidratosEmG = 3,
                ProteinasEmG = 10,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "g (120g)" }
            },

            new Ingrediente() {
                Id = 44,
                Name = "Fermento químico",
                CaloriasEmKcal = 5,
                CarboidratosEmG = 1,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de sopa (10g)" }
            },

            new Ingrediente() {
                Id = 45,
                Name = "Bicarbonato de sódio",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de sopa (15g)" }
            },

            new Ingrediente() {
                Id = 46,
                Name = "Whey protein baunilha",
                CaloriasEmKcal = 1200,
                CarboidratosEmG = 12,
                ProteinasEmG = 240,
                GordurasEmG = 6,
                UnidadeDeMedida = new List<string> { "g (300g)" }
            },

            new Ingrediente() {
                Id = 47,
                Name = "Ovo",
                CaloriasEmKcal = 68,
                CarboidratosEmG = 0.6f,
                ProteinasEmG = 6,
                GordurasEmG = 4.8f,
                UnidadeDeMedida = new List<string> { "unidade (68g)" }
            },
            new Ingrediente() {
                Id = 48,
                Name = "Peito de frango",
                CaloriasEmKcal = 880,
                CarboidratosEmG = 0,
                ProteinasEmG = 176,
                GordurasEmG = 8,
                UnidadeDeMedida = new List<string> { "g (800g)" }
            },
            new Ingrediente() {
                Id = 49,
                Name = "Pimenta do reino",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 1.5f,
                ProteinasEmG = 0.2f,
                GordurasEmG = 0.2f,
                UnidadeDeMedida = new List<string> { "colher de chá (2g)" }
            },
            new Ingrediente() {
                Id = 50,
                Name = "Molho shoyu",
                CaloriasEmKcal = 40,
                CarboidratosEmG = 4,
                ProteinasEmG = 2,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "ml (80ml)" }
            },
            new Ingrediente() {
                Id = 51,
                Name = "Bicarbonato de sódio",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de sopa (15g)" }
            },
            new Ingrediente() {
                Id = 52,
                Name = "Ketchup de baixa caloria",
                CaloriasEmKcal = 20,
                CarboidratosEmG = 6,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
            },
            new Ingrediente() {
                Id = 53,
                Name = "Pimenta dedo-de-moça",
                CaloriasEmKcal = 4,
                CarboidratosEmG = 1,
                ProteinasEmG = 0.2f,
                GordurasEmG = 0.1f,
                UnidadeDeMedida = new List<string> { "unidade pequena (10g)" }
            },
  new Ingrediente() {
                    Id = 16,
                    Name = "Mel",
                    CaloriasEmKcal = 64,
                    CarboidratosEmG = 17,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colher de sopa (21g)" }
                },            new Ingrediente() {
                Id = 55,
                Name = "Stevia",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "g (30g)" }
            },
            new Ingrediente() {
                Id = 56,
                Name = "Farinha de milho",
                CaloriasEmKcal = 148,
                CarboidratosEmG = 36,
                ProteinasEmG = 2,
                GordurasEmG = 1,
                UnidadeDeMedida = new List<string> { "g (40g)" }
            },
            new Ingrediente() {
                Id = 57,
                Name = "Vinagre de arroz",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 1,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colheres de sopa (30ml)" }
            },

            new Ingrediente() {
                Id = 58,
                Name = "Abobrinha",
                CaloriasEmKcal = 66,
                CarboidratosEmG = 12,
                ProteinasEmG = 4,
                GordurasEmG = 1,
                UnidadeDeMedida = new List<string> { "unidades médias (400g)" }
            },
            new Ingrediente() {
                Id = 59,
                Name = "Batata",
                CaloriasEmKcal = 231,
                CarboidratosEmG = 53,
                ProteinasEmG = 6,
                GordurasEmG = 0.3f,
                UnidadeDeMedida = new List<string> { "unidades médias (300g)" }
            },

            new Ingrediente() {
                Id = 61,
                Name = "Parmesão ralado",
                CaloriasEmKcal = 328,
                CarboidratosEmG = 4,
                ProteinasEmG = 28,
                GordurasEmG = 22,
                UnidadeDeMedida = new List<string> { "g (80g)" }
            },
            new Ingrediente() {
                Id = 63,
                Name = "Farinha de mandioca",
                CaloriasEmKcal = 140,
                CarboidratosEmG = 35,
                ProteinasEmG = 1,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "xícara (40g)" }
            },
            new Ingrediente() {
                Id = 64,
                Name = "Sal",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "g (1g)" }
            },

            new Ingrediente() {
                Id = 65,
                Name = "Ovo",
                CaloriasEmKcal = 68,
                CarboidratosEmG = 0.6f,
                ProteinasEmG = 6,
                GordurasEmG = 4.8f,
                UnidadeDeMedida = new List<string> { "unidade (68g)" }
            },
            new Ingrediente() {
                Id = 66,
                Name = "Farinha de aveia",
                CaloriasEmKcal = 76,
                CarboidratosEmG = 13,
                ProteinasEmG = 3,
                GordurasEmG = 1.5f,
                UnidadeDeMedida = new List<string> { "colheres de sopa (20g)" }
            },
            new Ingrediente() {
                Id = 67,
                Name = "Iogurte natural",
                CaloriasEmKcal = 60,
                CarboidratosEmG = 6,
                ProteinasEmG = 5,
                GordurasEmG = 1,
                UnidadeDeMedida = new List<string> { "xícara (120g)" }
            },
            new Ingrediente() {
                Id = 68,
                Name = "Fermento em pó",
                CaloriasEmKcal = 5,
                CarboidratosEmG = 1,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de chá (5g)" }
            },
            new Ingrediente() {
                Id = 69,
                Name = "Raspas de limão",
                CaloriasEmKcal = 1,
                CarboidratosEmG = 0.5f,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "quantidade pequena (2g)" }
            },
            new Ingrediente() {
                Id = 70,
                Name = "Whey protein de limão",
                CaloriasEmKcal = 120,
                CarboidratosEmG = 2,
                ProteinasEmG = 24,
                GordurasEmG = 1,
                UnidadeDeMedida = new List<string> { "g (30g)" }
            },
            new Ingrediente() {
                Id = 72,
                Name = "Frango desfiado",
                CaloriasEmKcal = 330,
                CarboidratosEmG = 0,
                ProteinasEmG = 60,
                GordurasEmG = 7,
                UnidadeDeMedida = new List<string> { "g (200g)" }
            },
            new Ingrediente() {
                Id = 73,
                Name = "Tapioca",
                CaloriasEmKcal = 144,
                CarboidratosEmG = 36,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colheres de sopa (40g)" }
            },
  new Ingrediente() {
                    Id = 8,
                    Name = "Azeite",
                    CaloriasEmKcal = 45,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 5,
                    UnidadeDeMedida = new List<string> { "fio (5g)" }
                },            new Ingrediente() {
                Id = 75,
                Name = "Sal, pimenta e cheiro verde",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "quantidades mínimas" }
            },

            new Ingrediente() {
                Id = 76,
                Name = "Aveia em flocos",
                CaloriasEmKcal = 389,
                CarboidratosEmG = 66,
                ProteinasEmG = 16.9f,
                GordurasEmG = 6.9f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 77,
                Name = "Leite (integral)",
                CaloriasEmKcal = 122,
                CarboidratosEmG = 12,
                ProteinasEmG = 8,
                GordurasEmG = 7.5f,
                UnidadeDeMedida = new List<string> { "ml (200ml)" }
            },
            new Ingrediente() {
                Id = 78,
                Name = "Bebida vegetal (soja)",
                CaloriasEmKcal = 80,
                CarboidratosEmG = 6,
                ProteinasEmG = 7,
                GordurasEmG = 4,
                UnidadeDeMedida = new List<string> { "ml (200ml)" }
            },
            new Ingrediente() {
                Id = 79,
                Name = "Banana pequena",
                CaloriasEmKcal = 89,
                CarboidratosEmG = 23,
                ProteinasEmG = 1.1f,
                GordurasEmG = 0.3f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 80,
                Name = "Morango",
                CaloriasEmKcal = 32,
                CarboidratosEmG = 7.7f,
                ProteinasEmG = 0.7f,
                GordurasEmG = 0.3f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
  new Ingrediente() {
                    Id = 16,
                    Name = "Mel",
                    CaloriasEmKcal = 64,
                    CarboidratosEmG = 17,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colher de sopa (21g)" }
                },            new Ingrediente() {
                Id = 82,
                Name = "Sementes/Oleaginosas (mistura)",
                CaloriasEmKcal = 180,
                CarboidratosEmG = 6.2f,
                ProteinasEmG = 6.5f,
                GordurasEmG = 16.5f,
                UnidadeDeMedida = new List<string> { "g (30g)" }
            },
            new Ingrediente() {
                Id = 83,
                Name = "Canela",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 2.1f,
                ProteinasEmG = 0.1f,
                GordurasEmG = 0.2f,
                UnidadeDeMedida = new List<string> { "colher de chá (2.6fg)" }
            },
            new Ingrediente() {
                Id = 84,
                Name = "Banana",
                CaloriasEmKcal = 89,
                CarboidratosEmG = 23,
                ProteinasEmG = 1.1f,
                GordurasEmG = 0.3f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 85,
                Name = "Ovo",
                CaloriasEmKcal = 68,
                CarboidratosEmG = 0.6f,
                ProteinasEmG = 6,
                GordurasEmG = 4.8f,
                UnidadeDeMedida = new List<string> { "unidade (50g)" }
            },
  new Ingrediente() {
                    Id = 12,
                    Name = "Aveia",
                    CaloriasEmKcal = 114,
                    CarboidratosEmG = 19,
                    ProteinasEmG = 4,
                    GordurasEmG = 2,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
                },            new Ingrediente() {
                Id = 87,
                Name = "Fermento em pó",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 1.5f,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de chá (5g)" }
            },
            new Ingrediente() {
                Id = 88,
                Name = "Manteiga",
                CaloriasEmKcal = 72,
                CarboidratosEmG = 0.1f,
                ProteinasEmG = 0.1f,
                GordurasEmG = 8.1f,
                UnidadeDeMedida = new List<string> { "g (10g)" }
            },

            new Ingrediente() {
                Id = 89,
                Name = "Massa de tapioca",
                CaloriasEmKcal = 160,
                CarboidratosEmG = 38,
                ProteinasEmG = 1.6f,
                GordurasEmG = 0.4f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 90,
                Name = "Ovo",
                CaloriasEmKcal = 68,
                CarboidratosEmG = 0.6f,
                ProteinasEmG = 6,
                GordurasEmG = 4.8f,
                UnidadeDeMedida = new List<string> { "unidade (50g)" }
            },
            new Ingrediente() {
                Id = 91,
                Name = "Cacau em pó",
                CaloriasEmKcal = 24,
                CarboidratosEmG = 3.2f,
                ProteinasEmG = 2.0f,
                GordurasEmG = 0.5f,
                UnidadeDeMedida = new List<string> { "g (10g)" }
            },
  new Ingrediente() {
                    Id = 16,
                    Name = "Mel",
                    CaloriasEmKcal = 64,
                    CarboidratosEmG = 17,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colher de sopa (21g)" }
                },            new Ingrediente() {
                Id = 93,
                Name = "Leite (integral)",
                CaloriasEmKcal = 122,
                CarboidratosEmG = 12,
                ProteinasEmG = 8,
                GordurasEmG = 7.5f,
                UnidadeDeMedida = new List<string> { "ml (200ml)" }
            },
            new Ingrediente() {
                Id = 94,
                Name = "Fermento em pó",
                CaloriasEmKcal = 6,
                CarboidratosEmG = 1.5f,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de chá (5g)" }
            },
            new Ingrediente() {
                Id = 95,
                Name = "Manteiga",
                CaloriasEmKcal = 72,
                CarboidratosEmG = 0.1f,
                ProteinasEmG = 0.1f,
                GordurasEmG = 8.1f,
                UnidadeDeMedida = new List<string> { "g (10g)" }
            },
            new Ingrediente() {
                Id = 96,
                Name = "Massa de tapioca",
                CaloriasEmKcal = 160,
                CarboidratosEmG = 38,
                ProteinasEmG = 1.6f,
                GordurasEmG = 0.4f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 97,
                Name = "Ovo",
                CaloriasEmKcal = 68,
                CarboidratosEmG = 0.6f,
                ProteinasEmG = 6,
                GordurasEmG = 4.8f,
                UnidadeDeMedida = new List<string> { "unidade (50g)" }
            },
            new Ingrediente() {
                Id = 98,
                Name = "Frango desfiado",
                CaloriasEmKcal = 165,
                CarboidratosEmG = 0,
                ProteinasEmG = 31,
                GordurasEmG = 3.6f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 99,
                Name = "Queijo cottage",
                CaloriasEmKcal = 98,
                CarboidratosEmG = 3.4f,
                ProteinasEmG = 11.1f,
                GordurasEmG = 4.3f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
            new Ingrediente() {
                Id = 100,
                Name = "Ricota",
                CaloriasEmKcal = 150,
                CarboidratosEmG = 6.0f,
                ProteinasEmG = 11.0f,
                GordurasEmG = 8.0f,
                UnidadeDeMedida = new List<string> { "g (100g)" }
            },
  new Ingrediente() {
                    Id = 8,
                    Name = "Azeite",
                    CaloriasEmKcal = 45,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 5,
                    UnidadeDeMedida = new List<string> { "fio (5g)" }
                },            new Ingrediente() {
                Id = 102,
                Name = "Sal, pimenta e cheiro verde",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "Q.B." }
            },
            new Ingrediente() {
            Id = 103,
            Name = "Iogurte grego natural",
            CaloriasEmKcal = 100,
            CarboidratosEmG = 6,
            ProteinasEmG = 10,
            GordurasEmG = 4,
            UnidadeDeMedida = new List<string> { "pote (170g)" }
            },
            new Ingrediente() {
                Id = 104,
                Name = "Granola",
                CaloriasEmKcal = 120,
                CarboidratosEmG = 20,
                ProteinasEmG = 3,
                GordurasEmG = 5,
                UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
            },
  new Ingrediente() {
                    Id = 16,
                    Name = "Mel",
                    CaloriasEmKcal = 64,
                    CarboidratosEmG = 17,
                    ProteinasEmG = 0,
                    GordurasEmG = 0,
                    UnidadeDeMedida = new List<string> { "colher de sopa (21g)" }
                },            new Ingrediente() {
                Id = 107,
                Name = "Banana pequena",
                CaloriasEmKcal = 108,
                CarboidratosEmG = 28,
                ProteinasEmG = 1.2f,
                GordurasEmG = 0.6f,
                UnidadeDeMedida = new List<string> { "unidades (120g)" }
            },
            new Ingrediente() {
                Id = 109,
                Name = "Batata doce",
                CaloriasEmKcal = 180,
                CarboidratosEmG = 41,
                ProteinasEmG = 4,
                GordurasEmG = 0.3f,
                UnidadeDeMedida = new List<string> { "média (200g)" }
            },
  new Ingrediente() {
                    Id = 12,
                    Name = "Aveia",
                    CaloriasEmKcal = 114,
                    CarboidratosEmG = 19,
                    ProteinasEmG = 4,
                    GordurasEmG = 2,
                    UnidadeDeMedida = new List<string> { "colheres de sopa (30g)" }
                },            new Ingrediente() {
                Id = 111,
                Name = "Fermento em pó",
                CaloriasEmKcal = 10,
                CarboidratosEmG = 2,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de sopa (10g)" }
            },
  new Ingrediente() {
                    Id = 8,
                    Name = "Azeite",
                    CaloriasEmKcal = 45,
                    CarboidratosEmG = 0,
                    ProteinasEmG = 0,
                    GordurasEmG = 5,
                    UnidadeDeMedida = new List<string> { "fio (5g)" }
                },            new Ingrediente() {
                Id = 113,
                Name = "Sal",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "1g" }
            },
            new Ingrediente() {
                Id = 114,
                Name = "Adoçante culinário em pó",
                CaloriasEmKcal = 0,
                CarboidratosEmG = 0,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "xícara (200 g, aproximadamente)" }
            },
            new Ingrediente() {
                Id = 116,
                Name = "Leite em pó desnatado",
                CaloriasEmKcal = 360,
                CarboidratosEmG = 51,
                ProteinasEmG = 34,
                GordurasEmG = 1.5f,
                UnidadeDeMedida = new List<string> { "xícara (100 g)" }
            },
            new Ingrediente() {
                Id = 118,
                Name = "Leite desnatado",
                CaloriasEmKcal = 80,
                CarboidratosEmG = 12,
                ProteinasEmG = 8,
                GordurasEmG = 0.2f,
                UnidadeDeMedida = new List<string> { "xícaras (480 ml)" }
            },
            new Ingrediente() {
                Id = 120,
                Name = "Amido de milho",
                CaloriasEmKcal = 37,
                CarboidratosEmG = 9.4f,
                ProteinasEmG = 0.1f,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de sobremesa (10 g)" }
            },
            new Ingrediente() {
                Id = 121,
                Name = "Essência de baunilha",
                CaloriasEmKcal = 12,
                CarboidratosEmG = 0.5f,
                ProteinasEmG = 0,
                GordurasEmG = 0,
                UnidadeDeMedida = new List<string> { "colher de chá (5 ml)" }
            }









            








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
