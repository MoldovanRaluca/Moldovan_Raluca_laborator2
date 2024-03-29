﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Raluca_laborator2.Models;

namespace Moldovan_Raluca_laborator2.Data
{
    public class Moldovan_Raluca_laborator2Context : DbContext
    {
        public Moldovan_Raluca_laborator2Context (DbContextOptions<Moldovan_Raluca_laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Raluca_laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Moldovan_Raluca_laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Moldovan_Raluca_laborator2.Models.Author>? Author { get; set; }
    }
}
