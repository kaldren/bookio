using Bookio.SPA.Data;
using Bookio.SPA.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bookio.SPA.Services
{
    public class BookService
    {
        private IWebHostEnvironment _webHostEnvironment;
        private ApplicationDbContext _dbContext;

        private string JsonBooksFilePath
        {
            get { return Path.Combine(_webHostEnvironment.ContentRootPath, "Data", "books.json"); }
        }

        public BookService(IWebHostEnvironment webHostEnvironment, ApplicationDbContext dbContext)
        {
            _webHostEnvironment = webHostEnvironment;
            _dbContext = dbContext;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _dbContext.Books.Include(x => x.BookAuthors).Include(x => x.BookCategories);
        }
    }
}
