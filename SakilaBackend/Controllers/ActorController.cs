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
    public class ActorController : ControllerBase
    {
        [HttpGet("/getAllActors")]
        public List<Actor> GetActors()
        {
            List<Actor> actors;
            using (var context = new sakilaContext())
            {
                actors = context.Actors.ToList();
            }
            return actors;
        }

        [HttpGet("/getNamesOfAllActors")]
        public IQueryable GetActorsByName()
        {
            IQueryable actors;
            using (var context = new sakilaContext())
            {
                actors = context.Actors.
                    Select(a => new
                    {
                        a.FirstName,
                        a.LastName
                    }).
                    ToList().
                    AsQueryable();
            }
            return actors;
        }

        [HttpGet("/getActor/{actorId:int}")] 
        public IQueryable GetActor(int actorId)
        {
            try
            {
                IQueryable actor;
                using (var context = new sakilaContext())
                {
                    actor = context.Actors.
                        Where(a => a.ActorId.Equals((short)actorId)).
                        Select(a => new
                        {
                            a.FirstName,
                            a.LastName
                        }).
                        ToList().
                        AsQueryable();
                }
                return actor;
            }
            catch
            {
                Console.WriteLine("actorId does not exist");
                return null;
            }
        }

        [HttpGet("/getActorId/{firstname=string}/{lastname=string}")]
        public short GetActorId(string firstname, string lastname)
        {
            try
            {
                short actor;
                using (var context = new sakilaContext())
                {
                    actor = context.Actors.
                        Where(a => a.FirstName.Equals(firstname) && (a.LastName.Equals(lastname))).
                        Select(a => a.ActorId).
                        First();
                }
                return actor;
            }
            catch
            {
                Console.WriteLine("Actor with that name does not exist");
                return 0;
            }
        }

        [HttpPut("/setNewActor/{firstname=string}/{lastname=string}")]
        public void PutActor(string firstname, string lastname)
        {
            using (var context = new sakilaContext())
            {
                Actor actor = new Actor();
                actor.FirstName = firstname;
                actor.LastName = lastname;
                context.Actors.Add(actor);
                context.SaveChanges();
            }
        }

        [HttpPut("/updateExistingActorName/{originalfirstname=string}/{originallastname=string}/{newfirstname=string}/{newlastname=string}")]
        public Actor PutActorName(string originalfirstname, string originallastname, string newfirstname, string newlastname)
        {

            try
            {
                using (var context = new sakilaContext())
                {
                    Actor actor = context.Actors.
                            Where(a => a.FirstName.Equals(originalfirstname) && (a.LastName.Equals(originallastname))).
                            First();
                    actor.FirstName = newfirstname;
                    actor.LastName = newlastname;
                    context.SaveChanges();
                    return actor;
                }
            }
            catch
            {
                Console.WriteLine("Actor with that name does not exist");
                return null;
            }
        }

        [HttpDelete("/deleteActor/{actorId:int}")]
        public void DeleteActorName(int actorId)
        {
            try
            {
                using (var context = new sakilaContext())
                {
                    Actor actor = context.Actors.
                        Where(a => a.ActorId.Equals((short)actorId)).
                        First();
                    context.Actors.Remove(actor);
                    context.SaveChanges();
                }
            }
            catch
            {
                Console.WriteLine("Actor with that ID does not exist");
            }
        }

        [HttpGet("/getallactorfilms")]
        public dynamic GetAllActorFilms()
        {
            using (var context = new sakilaContext())
            {
                object AnonymousReturn()
                {
                    return new
                    {
                        allActorfilms = (from actor in context.Actors
                                         join filmactor in context.FilmActors
                                         on actor.ActorId equals filmactor.ActorId
                                         join film in context.Films
                                         on filmactor.FilmId equals film.FilmId
                                         select new
                                         {
                                             ActorFirstName = actor.FirstName,
                                             ActorLastName = actor.LastName,
                                             Title = film.Title,
                                             Description = film.Description
                                         }).ToList()
                    };
                }
                return AnonymousReturn();
            }
        }

        [HttpGet("/getactorfilms/{actorId:int}")]
        public dynamic GetActorFilms(int actorId)
        {
            using (var context = new sakilaContext())
            {
                object AnonymousReturn()
                {
                    return new
                    {
                        actorFilms = (from actor in context.Actors
                                      join filmactor in context.FilmActors
                                      on actor.ActorId equals filmactor.ActorId
                                      join film in context.Films
                                      on filmactor.FilmId equals film.FilmId
                                      where (actor.ActorId == actorId)
                                      select new
                                      {
                                          ActorFirstName = actor.FirstName,
                                          ActorLastName = actor.LastName,
                                          Title = film.Title,
                                          Description = film.Description
                                      }).ToList()
                    };
                }               
                return AnonymousReturn();
            }            
        }
    }
}
