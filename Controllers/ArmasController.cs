using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using A09.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmasController(DataContext context)
        {
            _context = context;
        }

        //  GET por ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Arma a = await _context.TB_ARMAS
                    .FirstOrDefaultAsync(aBusca => aBusca.Id == id);

                if (a == null)
                    return NotFound("Arma não encontrada");

                return Ok(a);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

        //  GET ALL
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Arma> lista = await _context.TB_ARMAS.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

        //  POST
        [HttpPost]
        public async Task<IActionResult> Add(Arma novaArma)
        {
            try
            {
                if (novaArma.Dano == 0)
                    throw new Exception("O Dano da arma não pode ser 0");

                Personagem p = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(pBusca => pBusca.Id == novaArma.PersonagemId);

                if (p == null)
                    throw new Exception("Não existe personagem com o Id informado");

                await _context.TB_ARMAS.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

        //  PUT
        [HttpPut]
        public async Task<IActionResult> Update(Arma novaArma)
        {
            try
            {
                _context.TB_ARMAS.Update(novaArma);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

        //  DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Arma aRemover = await _context.TB_ARMAS
                    .FirstOrDefaultAsync(p => p.Id == id);

                if (aRemover == null)
                    return NotFound("Arma não encontrada");

                _context.TB_ARMAS.Remove(aRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
    }
}