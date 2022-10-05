using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;
using tech_test_payment_api.Entities;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly AplicacaoContext _context;

        public ProdutoController(AplicacaoContext context)
        {
            _context = context;
        }

        [HttpGet("id")]
        public IActionResult ObterPorId(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Criar(ProdutoEntity produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = produto.Id }, produto);
        }

    }
}
