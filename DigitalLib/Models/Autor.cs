using System.ComponentModel.DataAnnotations;

namespace DigitalLib.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public ICollection<Livro>? Livros { get; set; }
    }
}
