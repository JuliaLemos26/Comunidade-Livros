using Microsoft.EntityFrameworkCore;

namespace ComunidadeLivros.Shared.Data.Models
{
    public class Autor
    {
        public Guid Id { get; set; }

        public required string Nome { get; set; }

        public string? Sobre { get; set; }

        public required List<Livro> Livros { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public required Genero Genero { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public required Midia Midia { get; set; }
    }
}
