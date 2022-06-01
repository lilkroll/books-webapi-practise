﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace books.Data.Models
{
    public class Book_author
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
