﻿using System.ComponentModel.DataAnnotations;

namespace ComunidadeLivros.Shared.Data.Models
{
    public class Genero
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string? Nome { get; set; } = null; 

        public List<Livro> Livros { get; set; } = new();

        public List<Autor> Autores { get; set; } = new();
    }
}
