using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        // a) GetByNome - busca aproximada por nome
        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            var pBusca = personagens
                .FirstOrDefault(p => p.Nome.IndexOf(nome, StringComparison.OrdinalIgnoreCase) >= 0);

            if (pBusca == null)
                return NotFound("Personagem não encontrado");

            return Ok(pBusca);
        }

        // b) GetClerigoMago - remove cavaleiros e exibe lista decrescente por PontosVida
        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            List<Personagem> lista = new List<Personagem>();
            int count = 0;

            for (int i = 0; i < personagens.Count; i++)
            {
                if (personagens[i].Classe != ClasseEnum.Cavaleiro)
                {
                    lista.Add(personagens[i]);
                    count++;
                }
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (lista[i].PontosVida < lista[j].PontosVida)
                    {
                        Personagem temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }

            return Ok(lista);
        }

        // c) GetEstatisticas - quantidade e soma da inteligência
        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            int quantidade = personagens.Count;
            int somaInteligencia = 0;

            for (int i = 0; i < personagens.Count; i++)
                somaInteligencia += personagens[i].Inteligencia;

            var resultado = new
            {
                QuantidadePersonagens = quantidade,
                SomaInteligencia = somaInteligencia
            };

            return Ok(resultado);
        }

        // d) PostValidacao - não permitir Defesa < 10 ou Inteligência > 30
        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem p)
        {
            if (p.Defesa < 10 || p.Inteligencia > 30)
                return BadRequest("Defesa deve ser maior ou igual a 10 e Inteligência menor ou igual a 30.");

            personagens.Add(p);
            return Ok(p);
        }

        // e) PostValidacaoMago - valida Mago
        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem p)
        {
            if (p.Classe == ClasseEnum.Mago && p.Inteligencia < 35)
                return BadRequest("Mago deve ter Inteligência maior ou igual a 35.");

            personagens.Add(p);
            return Ok(p);
        }

        // f) GetByClasse - busca por ClasseEnum
        [HttpGet("GetByClasse/{classeid}")]
        public IActionResult GetByClass(int classeid)
        {
            ClasseEnum enumDigitado = (ClasseEnum)classeid;
            List<Personagem> busca = personagens.FindAll(x => x.Classe == enumDigitado);

            return Ok(busca);
        }
    }
}