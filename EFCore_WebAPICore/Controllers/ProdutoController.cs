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
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ClienteContext _context { get; set; } = new ClienteContext();

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return produtos;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<ActionResult<Produto>> Post([FromBody] Produto model)
        {
            if (ModelState.IsValid)
            {
                _context.Produtos.Add(model);
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
