using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookio.SPA.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public DateTime PublishDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }
        public Author[] Authors { get; set; }
        public Category[] Categories { get; set; }
    }
}
