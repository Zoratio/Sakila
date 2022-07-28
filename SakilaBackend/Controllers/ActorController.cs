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

        [HttpGet("/getactor/{actorId:int}")]    //error handling for if the id does not exist
        public string GetActor(int actorId)
        {
            using (var context = new sakilaContext())
            {
                string actor = context.Actors.
                    Where(a => a.ActorId.Equals((short)actorId)).
                    Select(a => a.FirstName).
                    First();

                return actor;
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
            using (var context = new sakilaContext())
            {
                Actor actor = context.Actors.
                    Where(a => a.FirstName.Equals(originalfirstname)).
                    First();
                actor.FirstName = newfirstname;
                context.SaveChanges();
            }
        }

        [HttpDelete("/deleteactor/{actorId:int}")]    //error handling for if the id does not exist
        public void DeleteActorName(int actorId)
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
    }
}
