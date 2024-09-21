using GoodGood.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoodGood.Controllers;

public class ReceitaController : Controller {
    private readonly ComidaDbContext _dbContext;
    public ReceitaController(ComidaDbContext dbContext) {
        _dbContext = dbContext;
    }

    public ActionResult Index(int id) {
        var receita = _dbContext.Receitas
            .Include(r => r.IngredientesDaReceita)
            .ThenInclude(ri => ri.Ingrediente)
            .Where(r => r.Id == id)
            .ToList()[0];

        if (receita == null) 
            return NotFound();

        return View(receita);
    }
}