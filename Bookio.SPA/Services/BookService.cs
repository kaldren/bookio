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
        private ApplicationDbContext _dbContext;

        public BookService(IWebHostEnvironment webHostEnvironment, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _dbContext.Books
                .Include(x => x.BookAuthors)
                .ThenInclude(x => x.Author)
                .Include(x => x.BookCategories)
                .ThenInclude(x => x.Category);
        }
    }
}
