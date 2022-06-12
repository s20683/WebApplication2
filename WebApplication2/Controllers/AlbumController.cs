using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {

        private readonly IAlbumsDbService _albumDbService;

        public AlbumController(IAlbumsDbService albumsDbService) {
            _albumDbService = albumsDbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbum(int IdAlbum) {
            try
            {
                if (IdAlbum != 0)
                    return Ok(await _albumDbService.GetAlbum(IdAlbum));
                return Ok(await _albumDbService.GetAlbums());
            }
            catch (System.Exception) {
                return Conflict();
            }
        }

    }
}
