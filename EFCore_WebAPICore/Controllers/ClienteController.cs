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
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteContext _context { get; set; } = new ClienteContext();

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            var clientes = await _context.Clientes.AsNoTracking().Include(p => p.Pedidos).ToListAsync();
            return clientes;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Cliente>>> GetById(int id)
        {
            var clientes = await _context.Clientes.AsNoTracking().Include(p => p.Pedidos).Where(c => c.Id == id).ToListAsync();
            return clientes;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<ActionResult<Cliente>> Post([FromBody] Cliente model)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(model);
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
