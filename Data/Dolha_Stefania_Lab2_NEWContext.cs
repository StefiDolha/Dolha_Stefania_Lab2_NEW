using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dolha_Stefania_Lab2_NEW.Models;

namespace Dolha_Stefania_Lab2_NEW.Data
{
    public class Dolha_Stefania_Lab2_NEWContext : DbContext
    {
        public Dolha_Stefania_Lab2_NEWContext (DbContextOptions<Dolha_Stefania_Lab2_NEWContext> options)
            : base(options)
        {
        }

        public DbSet<Dolha_Stefania_Lab2_NEW.Models.Book> Book { get; set; } = default!;
        public DbSet<Dolha_Stefania_Lab2_NEW.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Dolha_Stefania_Lab2_NEW.Models.Author> Author { get; set; } = default!;
    }
}
