using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enums;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensController : ControllerBase
    {
        // Lista de personagens em memória
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago }
        };

        // GET /Personagens/Get
        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(personagens[0]);
        }

        // GET /Personagens/GetAll
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(personagens);
        }

        // GET /Personagens/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var personagem = personagens.FirstOrDefault(p => p.Id == id);
            if (personagem == null)
                return NotFound("Personagem não encontrado");

            return Ok(personagem);
        }

        // POST /Personagens
        [HttpPost]
        public IActionResult AddPersonagem(Personagem novoPersonagem)
        {
            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        // DELETE /Personagens/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePersonagem(int id)
        {
            var personagem = personagens.FirstOrDefault(p => p.Id == id);
            if (personagem == null)
                return NotFound("Personagem não encontrado");

            personagens.Remove(personagem);
            return Ok(personagens);
        }

        // PUT /Personagens
        [HttpPut]
        public IActionResult UpdatePersonagem(Personagem p)
        {
            var personagem = personagens.FirstOrDefault(per => per.Id == p.Id);
            if (personagem == null)
                return NotFound("Personagem não encontrado");

            personagem.Nome = p.Nome;
            personagem.PontosVida = p.PontosVida;
            personagem.Forca = p.Forca;
            personagem.Defesa = p.Defesa;
            personagem.Inteligencia = p.Inteligencia;
            personagem.Classe = p.Classe;

            return Ok(personagens);
        }
    }
}