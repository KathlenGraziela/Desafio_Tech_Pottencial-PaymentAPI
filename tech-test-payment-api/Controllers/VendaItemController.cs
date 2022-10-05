using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Context;
using tech_test_payment_api.Entities;
using tech_test_payment_api.Enum;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaItemController : ControllerBase
    {
        private readonly AplicacaoContext _context;
        public VendaItemController(AplicacaoContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendaItem = _context.VendasItens.Find(id);
            if (vendaItem == null)
                return NotFound();

            return Ok(vendaItem);
        }

        [HttpPost]
        public IActionResult Criar(VendaItemEntity vendaItem)
        {
            _context.VendasItens.Add(vendaItem);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = vendaItem.Id }, vendaItem);
        }
    }
}
