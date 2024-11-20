using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dolha_Stefania_Lab2_NEW.Data;
using Dolha_Stefania_Lab2_NEW.Models;

namespace Dolha_Stefania_Lab2_NEW.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Dolha_Stefania_Lab2_NEW.Data.Dolha_Stefania_Lab2_NEWContext _context;

        public CreateModel(Dolha_Stefania_Lab2_NEW.Data.Dolha_Stefania_Lab2_NEWContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
