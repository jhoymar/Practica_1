using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practica_1.Data;

namespace Practica_1.Helpers
{

    public class ComboHelpers : IComboHelpers
    {
        private readonly DataContext _context;

        public ComboHelpers(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync()
        {
            List<SelectListItem> list = await _context.Entrances.Select(e => new SelectListItem
            {
                Value = $"{e.Id}",
                Text = e.Description,
                
            })
                .OrderBy(e => e.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "[]",
               
            });

            return list;
        }
    }
}
