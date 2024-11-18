using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dolha_Stefania_Lab2_NEW.Data;
using Dolha_Stefania_Lab2_NEW.Models;

namespace Dolha_Stefania_Lab2_NEW.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Dolha_Stefania_Lab2_NEW.Data.Dolha_Stefania_Lab2_NEWContext _context;

        public IndexModel(Dolha_Stefania_Lab2_NEW.Data.Dolha_Stefania_Lab2_NEWContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
