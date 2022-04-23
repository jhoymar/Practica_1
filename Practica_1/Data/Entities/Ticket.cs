using System.ComponentModel.DataAnnotations;

namespace Practica_1.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public bool WasUsed { get; set; } = false;

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Name { get; set; }

        public Entrance? Entrace { get; set; }

        public DateTime? DateTime { get; set; }


    }
}
