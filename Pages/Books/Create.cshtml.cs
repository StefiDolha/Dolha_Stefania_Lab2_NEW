using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dolha_Stefania_Lab2_NEW.Data;
using Dolha_Stefania_Lab2_NEW.Models;
using Dolha_Stefania_Lab2_NEW.Models;

namespace Dolha_Stefania_Lab2_NEW.Pages.Books
{
    public class CreateModel : BookCategoriesPageModel
    {
        private readonly Dolha_Stefania_Lab2_NEW.Data.Dolha_Stefania_Lab2_NEWContext _context;

        public CreateModel(Dolha_Stefania_Lab2_NEW.Data.Dolha_Stefania_Lab2_NEWContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {   /* var authorList = _context.Author.Select(x => new
           {
            x.ID,
            FullName = x.LastName + " " + x.FirstName
            });
            */
            // daca am adaugat o proprietate FullName in clasa Author
            // ViewData["AuthorID"] = new SelectList(authorList, "ID", "FullName");
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
            "PublisherName");
            var book = new Book();
            book.BookCategories = new List<BookCategory>();
            PopulateAssignedCategoryData(_context, book);

            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync(string[] selectedCategories)
        {
            var newBook = new Book();
            if (selectedCategories != null)
            {
                newBook.BookCategories = new List<BookCategory>();
                foreach (var cat in selectedCategories)
                {
                    var catToAdd = new BookCategory
                    {
                        CategoryID = int.Parse(cat)
                    };
                    newBook.BookCategories.Add(catToAdd);
                }
            }
            Book.BookCategories = newBook.BookCategories;
            _context.Book.Add(Book);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}

// For more information, see https://aka.ms/RazorPagesCRUD.
/*public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
*/