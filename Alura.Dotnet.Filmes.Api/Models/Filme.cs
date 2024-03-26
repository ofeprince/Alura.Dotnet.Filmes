using System.ComponentModel.DataAnnotations;

namespace Alura.Dotnet.Filmes.Api.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "Titulo do filme obrigatorio")]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Genero { get; set; }

        [Required]
        [Range(40, 600)]
        public int Duracao { get; set; }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Genero: {Genero}, duracao: {Duracao}";
        }
    }
}
