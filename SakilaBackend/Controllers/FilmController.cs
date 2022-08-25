using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SakilaBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;


namespace SakilaBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        [HttpGet("/searchFilmByPattern/{partialsearch=string}")]
        public List<Film> GetFilm(string partialsearch)
        {
            using (var context = new sakilaContext())
            {
                return (from film in context.Films
                        where film.Title.Contains(partialsearch)
                        select film).ToList();
            }
        }
    }
}
