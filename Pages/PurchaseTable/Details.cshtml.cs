using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreEntity.Data;
using CoreEntity.Models;

namespace CoreEntity.Pages.PurchaseTable
{
    public class DetailsModel : PageModel
    {
        private readonly CoreEntity.Data.CoreEntityContext _context;

        public DetailsModel(CoreEntity.Data.CoreEntityContext context)
        {
            _context = context;
        }

        public Purchase Purchase { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Purchase = await _context.Purchase.FirstOrDefaultAsync(m => m.Id == id);

            if (Purchase == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
