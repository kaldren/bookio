﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookio.SPA.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
