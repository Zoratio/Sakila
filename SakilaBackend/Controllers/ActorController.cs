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
    public class ActorController : ControllerBase
    {
        [HttpGet("/getallactors")]
        public List<Actor> GetActors()
        {
            List<Actor> actors;
            using (var context = new sakilaContext())
            {
                actors = context.Actors.ToList();
            }
            return actors;
        }
        
        [HttpGet("/getnamesofallactors")]
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

        [HttpGet("/getactor/{actorId:int}")]    //error handling for if the id does not exist
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

        [HttpGet("/getactorid/{firstname=string}/{lastname=string}")]
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

        [HttpPut("/setnewactor/{firstname=string}/{lastname=string}")]
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

        [HttpPatch("/updateexistingactorname/{originalfirstname=string}/{newfirstname=string}")]    //error handling for if the original name does not exist
        public void PatchActorName(string originalfirstname, string newfirstname)
        {
            try
            {
                using (var context = new sakilaContext())
                {
                    Actor actor = context.Actors.
                        Where(a => a.FirstName.Equals(originalfirstname)).
                        First();
                    actor.FirstName = newfirstname;
                    context.SaveChanges();
                }
            }
            catch
            {
                Console.WriteLine("Actor with that name does not exist");
            }
        }

        [HttpDelete("/deleteactor/{actorId:int}")]    //error handling for if the id does not exist
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
    }
}
