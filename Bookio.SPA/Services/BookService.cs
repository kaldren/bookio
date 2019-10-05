using Bookio.SPA.Models;
using Microsoft.AspNetCore.Hosting;
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

        private string JsonBooksFilePath
        {
            get { return Path.Combine(_webHostEnvironment.ContentRootPath, "Data", "books.json"); }
        }

        public BookService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            using (var jsonFileReader = File.OpenText(JsonBooksFilePath))
            {
                return JsonSerializer.Deserialize<Book[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}
