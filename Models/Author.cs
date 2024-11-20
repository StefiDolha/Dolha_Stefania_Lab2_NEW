using System.ComponentModel.DataAnnotations;

namespace Dolha_Stefania_Lab2_NEW.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Navigation property for Books
        public ICollection<Book>? Books { get; set; }
    }
}