﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreEntity.Data;
using CoreEntity.Models;

namespace CoreEntity.Pages.SaleTable
{
    public class DeleteModel : PageModel
    {
        private readonly CoreEntity.Data.CoreEntityContext _context;

        public DeleteModel(CoreEntity.Data.CoreEntityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sale Sale { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sale = await _context.Sale.FirstOrDefaultAsync(m => m.Id == id);

            if (Sale == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sale = await _context.Sale.FindAsync(id);

            if (Sale != null)
            {
                _context.Sale.Remove(Sale);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
