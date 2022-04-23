using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Practica_1.Models
{
    public class FormaTicketViemModel
    {
        public int Id { get; set; }

        public bool WasUsed { get; set; }

        [Display(Name = "Entrada")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una entrada.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int EntranceId { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Document { get; set; }
        public DateTime DateTime { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Name { get; set; }

        public IEnumerable<SelectListItem>? Entrances { get; set; }

    }
}
