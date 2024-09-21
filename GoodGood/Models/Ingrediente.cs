using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public class Ingrediente {
    public int Id { get; set; }
    [NotNull, Required]
    public string? Name { get; set; }
    [NotNull, Required]
    public List<string>? UnidadeDeMedida { get; set; }
    public float CaloriasEmKcal {get; set; } = 0;
    public float CarboidratosEmG {get; set; } = 0;
    public float ProteinasEmG {get; set; } = 0;
    public float GordurasEmG {get; set; } = 0;
}