namespace ComunidadeLivros.Shared.Data.Models
{
    public class Midia
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }

        public required string MidiaLink { get; set; }

        public required List<Livro> Livros { get; set; }

        public required List<Autor> Autores { get; set; }
    }
}
