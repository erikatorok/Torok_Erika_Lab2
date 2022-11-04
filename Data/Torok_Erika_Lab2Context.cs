using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Torok_Erika_Lab2.Models;

namespace Torok_Erika_Lab2.Data
{
    public class Torok_Erika_Lab2Context : DbContext
    {
        public Torok_Erika_Lab2Context (DbContextOptions<Torok_Erika_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Torok_Erika_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
