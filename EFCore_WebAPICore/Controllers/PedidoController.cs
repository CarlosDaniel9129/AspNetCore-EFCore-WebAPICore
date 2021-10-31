using EFCore_WebAPICore.Data;
using EFCore_WebAPICore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Controllers
{
    [Route("api/pedidos")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private ClienteContext _context { get; set; } = new ClienteContext();

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Pedido>>> Get()
        {
            var pedidos = await _context.Pedidos.ToListAsync();
            return pedidos;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<ActionResult<Pedido>> Post([FromBody] Pedido model)
        {
            if (ModelState.IsValid)
            {
                _context.Pedidos.Add(model);
                await _context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
