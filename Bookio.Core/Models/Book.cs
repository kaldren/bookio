﻿using System;
using System.Collections.Generic;

namespace Bookio.Core.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }
        public int Rating { get; set; }
        public int NumVoters { get; set; }
        public Author Author { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public Category Category { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }


    public class PublishedDate
    {
        public DateTime Date { get; set; }
    }
}
