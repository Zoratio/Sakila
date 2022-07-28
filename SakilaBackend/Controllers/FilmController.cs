using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SakilaBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {    
        [HttpGet("/getallfilms")]
        public IEnumerable<Film> GetFilms()
        {

            List<Film> films;
            using (var context = new sakilaContext())
            {
                films = context.Films.ToList();
            }

            return films;
        }
    }
}
