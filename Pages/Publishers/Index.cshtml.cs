﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Raluca_laborator2.Data;
using Moldovan_Raluca_laborator2.Models;

namespace Moldovan_Raluca_laborator2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Raluca_laborator2.Data.Moldovan_Raluca_laborator2Context _context;

        public IndexModel(Moldovan_Raluca_laborator2.Data.Moldovan_Raluca_laborator2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
