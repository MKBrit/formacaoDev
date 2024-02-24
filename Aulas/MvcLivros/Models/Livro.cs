using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLivros.Models
{
    public class Livro

    { 
        public int Id { get; set;}

        public string? Titulo { get; set;}

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]

        public DateTime DataLancamento { get; set; }
        [Display(Name = "Género")]

        public string? Genere { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Preço")]

        public decimal Preco { get; set; }
        
    }
}
