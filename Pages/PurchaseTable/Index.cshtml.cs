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
    public class IndexModel : PageModel
    {
        private readonly CoreEntity.Data.CoreEntityContext _context;

        public IndexModel(CoreEntity.Data.CoreEntityContext context)
        {
            _context = context;
        }

        public IList<Purchase> Purchase { get;set; }

        public async Task OnGetAsync()
        {
            Purchase = await _context.Purchase.ToListAsync();
        }
    }
}
