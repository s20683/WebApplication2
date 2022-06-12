using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.DTOs;

namespace WebApplication2.Services
{
    public interface IAlbumsDbService
    {
        Task<IEnumerable<SomeAlbum>> GetAlbums();
        Task<IEnumerable<SomeAlbum>> GetAlbum(int IdAlbum);
       
    }
}
