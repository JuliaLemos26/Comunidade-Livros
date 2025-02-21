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
        public Genero? Genero { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Autor? Autor { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Midia? Midia { get; set; }

    }
}
