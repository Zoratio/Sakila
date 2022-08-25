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
    public class RentalController : ControllerBase
    {

        [HttpGet("/getgenrerevenues")]
        public dynamic GetGenreRevenues()
        {
            using (var context = new sakilaContext())
            {
                object AnonymousReturn()
                {
                    return new
                    {
                        topGenres = (from rental in context.Rentals
                                      join inventory in context.Inventories
                                      on rental.InventoryId equals inventory.InventoryId
                                      join filmCategory in context.FilmCategories
                                      on inventory.FilmId equals filmCategory.FilmId
                                      join category in context.Categories
                                      on filmCategory.CategoryId equals category.CategoryId
                                      join payment in context.Payments
                                      on rental.RentalId equals payment.RentalId
                                      group payment.Amount by category.Name into g
                                      select new
                                      {
                                          name = g.Key,
                                          revenue = g.Sum()
                                      }).ToList()
                    };
                }
                return AnonymousReturn();
            }
        }
    }
}
