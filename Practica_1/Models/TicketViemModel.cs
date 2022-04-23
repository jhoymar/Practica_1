using System.ComponentModel.DataAnnotations;

namespace Practica_1.Models
{
    public class TicketViemModel
    {
        public class TicketViewModel
        {
            [Display(Name = "Codigo de la boleta")]
            [MaxLength(4, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string Id { get; set; }
        }
    }
}
