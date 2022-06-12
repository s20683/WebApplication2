using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.DTOs;

namespace WebApplication2.Services
{
    public class AlbumsDbService : IAlbumsDbService
    {
        private readonly MainDbContext mainDbContext;


public Task<IEnumerable<SomeAlbum>> GetAlbum(int IdAlbum)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SomeAlbum>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
