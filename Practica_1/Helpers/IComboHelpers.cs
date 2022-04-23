using Microsoft.AspNetCore.Mvc.Rendering;

namespace Practica_1.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();

    }
}
