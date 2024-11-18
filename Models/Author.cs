﻿namespace Dolha_Stefania_Lab2_NEW.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}
