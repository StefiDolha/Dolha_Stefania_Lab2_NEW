using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dolha_Stefania_Lab2_NEW.Data;
using Dolha_Stefania_Lab2_NEW.Models;

namespace Dolha_Stefania_Lab2_NEW.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Dolha_Stefania_Lab2_NEWContext _context;

        public IndexModel(Dolha_Stefania_Lab2_NEWContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

        public IList<Book> Books { get; set; } = new List<Book>();

        [BindProperty(SupportsGet = true)]
        public int? CategoryID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            Category = await _context.Category.ToListAsync();

            if (id.HasValue)
            {
                CategoryID = id;
                Books = await _context.Book
                    .Where(b => b.BookCategories.Any(bc => bc.CategoryID == id))
                    .Include(b => b.Author) 
                    .ToListAsync();
            }
        }
    }
}
