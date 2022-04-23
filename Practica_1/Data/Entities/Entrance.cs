using System.ComponentModel.DataAnnotations;

namespace Practica_1.Data.Entities
{
    public class Entrance
    {

        public int Id { get; set; }

        [Display(Name = "Entrada")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Description { get; set; }
    }
}
