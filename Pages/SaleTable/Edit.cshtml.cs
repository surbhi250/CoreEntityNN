﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreEntity.Data;
using CoreEntity.Models;

namespace CoreEntity.Pages.SaleTable
{
    public class EditModel : PageModel
    {
        private readonly CoreEntity.Data.CoreEntityContext _context;

        public EditModel(CoreEntity.Data.CoreEntityContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(Sale.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SaleExists(int id)
        {
            return _context.Sale.Any(e => e.Id == id);
        }
    }
}
