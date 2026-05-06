using System.Text.Json.Serialization;
using A09.Models;
using RpgApi.Models.Enums;

namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }

        public ClasseEnum Classe { get; set; }

        public byte[]? Foto { get; set; }

        public int? UsuarioId { get; set; }

        [JsonIgnore]
        public Usuario? Usuario { get; set; }

        [JsonIgnore]
        public Arma? Arma { get; set; }

        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }

        public List<PersonagemHabilidade> PersonagemHabilidades { get; set; } = [];
        
    }
}