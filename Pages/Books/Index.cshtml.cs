﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Raluca_laborator2.Data;
using Moldovan_Raluca_laborator2.Models;

namespace Moldovan_Raluca_laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Raluca_laborator2.Data.Moldovan_Raluca_laborator2Context _context;

        public IndexModel(Moldovan_Raluca_laborator2.Data.Moldovan_Raluca_laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.Author)
                .ToListAsync();
            }
        }
    }
}
