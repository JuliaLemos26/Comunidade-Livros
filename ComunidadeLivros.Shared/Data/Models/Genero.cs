namespace ComunidadeLivros.Shared.Data.Models
{
    public class Genero
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }

        public required List<Livro> Livros { get; set; }

        public required List<Autor> Autores { get; set; }
    }
}
