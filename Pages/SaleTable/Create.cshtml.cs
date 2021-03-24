﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreEntity.Data;
using CoreEntity.Models;

namespace CoreEntity.Pages.SaleTable
{
    public class CreateModel : PageModel
    {
        private readonly CoreEntity.Data.CoreEntityContext _context;

        public CreateModel(CoreEntity.Data.CoreEntityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sale Sale { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sale.Add(Sale);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
