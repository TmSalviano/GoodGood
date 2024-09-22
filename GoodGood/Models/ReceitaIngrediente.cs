using System.Diagnostics.CodeAnalysis;

namespace GoodGood.Models {
    public class ReceitaIngrediente {
        public int ReceitaId {get; set;} 
        [NotNull]   
        public Receita? Receita {get; set;}

        public int IngredienteId {get; set;}
        [NotNull]
        public  Ingrediente? Ingrediente {get; set;}

        public float Quantidade {get; set;}
    }
}