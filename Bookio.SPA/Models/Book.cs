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
        public int PageCount { get; set; }
        public PublishedDate PublishedDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }
        public List<string> Authors { get; set; }
        public List<object> Categories { get; set; }
    }


    public class PublishedDate
    {
        public DateTime Date { get; set; }
    }
}
