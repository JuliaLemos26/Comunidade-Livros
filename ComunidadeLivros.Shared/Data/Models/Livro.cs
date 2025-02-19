using Microsoft.EntityFrameworkCore;

namespace ComunidadeLivros.Shared.Data.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public required string Sinopse { get; set; }

        public string? Sobre { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public required Genero Genero { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public required Autor Autor { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public required Midia Midia { get; set; }

    }
}
