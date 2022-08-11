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

        [HttpGet("/getActor/{actorId:int}")]    //error handling for if the id does not exist
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

        [HttpPut("/updateExistingActorName/{originalfirstname=string}/{originallastname=string}/{newfirstname=string}/{newlastname=string}")]    //what if there are multiple actors with the same first name? need to take into consideration the first and last
        public void PutActorName(string originalfirstname, string originallastname, string newfirstname, string newlastname)
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
                }
            }
            catch
            {
                Console.WriteLine("Actor with that name does not exist");
            }
        }

        [HttpDelete("/deleteActor/{actorId:int}")]    //error handling for if the id does not exist
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

        //[HttpGet("/getactorfilms/{actorId:int}")]    //error handling for if the id does not exist
        //public IQueryable GetActorFilms(int actorId)
        //{
        //    try
        //    {
        //        IQueryable actor;
        //        using (var context = new sakilaContext())
        //        {
        //            ObjectSet<Film> films = context.Films;
        //            ObjectSet<FilmActor> filmActors = context.FilmActors;
        //            actor = context.Films
        //                .GroupJoin(
        //                    context.FilmActors,
        //                    a = > film.A
        //                    )


        //                //Where(a => a.ActorId.Equals((short)actorId)).
        //                //Select(a => new
        //                //{
        //                //    a.FirstName,
        //                //    a.LastName
        //                //}).
        //                //ToList().
        //                //AsQueryable();
        //        }
        //        return actor;
        //    }
        //    catch
        //    {
        //        Console.WriteLine("actorId does not exist");
        //        return null;
        //    }
        //}
    }
}
