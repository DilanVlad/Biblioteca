using System.ComponentModel.DataAnnotations;

namespace Biblioteca.API.Models
{
    public class Autor
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly AnioNac { get; set; }
        public List<Libro>? Libros { get; set; }
    }
}
