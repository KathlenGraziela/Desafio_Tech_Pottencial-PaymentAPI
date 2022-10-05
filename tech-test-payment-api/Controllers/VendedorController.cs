using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Context;
using tech_test_payment_api.Entities;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly AplicacaoContext _context;
        public VendedorController(AplicacaoContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            if (vendedor == null)
                return NotFound();

            return Ok(vendedor);
        }

        [HttpPost]
        public IActionResult Criar(VendedorEntity vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = vendedor.Id }, vendedor);
        }
    }
}
