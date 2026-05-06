using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        //Codificação geral dentro do corpo da controller.

        private readonly DataContext _context; //A

        public PersonagemHabilidadesController(DataContext context) //B
        {
            _context = context;
        }

            [HttpPost]
            public async Task<IActionResult> AddPersonagemHabilidadesAsync(PersonagemHabilidade novoPersonagemHabilidade)
            {
                try
                {
                    //codigo aqui
                }
                catch
                {
                    return BadRequest(ex.Message);
                }
            }
        }

    }