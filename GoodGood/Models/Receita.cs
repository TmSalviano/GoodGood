using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GoodGood.Models {
    public class Receita {
        public int Id { get; set;}
        [NotNull, Required]
        public string? Nome { get; set;}
        [NotNull, Required]
        public List<string>? ModeDePreparo { get; set;}
        [NotNull, Required]
        public string? Categoria1  { get; set;}
        [NotNull, Required]
        public string? Categoria2 { get; set;}
        [NotNull, Required]
        //Chave == ingrediente, Value == Quantitda
        public List<ReceitaIngrediente> IngredientesDaReceita { get; set;} = new List<ReceitaIngrediente>();
    }
}