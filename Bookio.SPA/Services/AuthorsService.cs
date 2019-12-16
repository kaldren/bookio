using Bookio.Core.Models;
using Bookio.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookio.SPA.Services
{
    public class AuthorsService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _dbContext.Authors.FirstOrDefaultAsync(x => x.AuthorId == id);
        }
    }
}
