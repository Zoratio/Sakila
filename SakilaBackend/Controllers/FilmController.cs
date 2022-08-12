﻿using Microsoft.AspNetCore.Mvc;
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
        //[HttpGet("/getAllFilms")]
        //public List<Film> GetFilms()
        //{
        //    List<Film> actors;
        //    using (var context = new sakilaContext())
        //    {
        //        actors = context.Actors.ToList();
        //    }
        //    return actors;
        //}
        
        //[HttpGet("/getNamesOfAllFilms")]
        //public IQueryable GetFilmsByName()
        //{
        //    IQueryable actors;
        //    using (var context = new sakilaContext())
        //    {
        //        actors = context.Actors.
        //            Select(a => new
        //            {
        //                a.FirstName,
        //                a.LastName
        //            }).
        //            ToList().
        //            AsQueryable();
        //    }
        //    return actors;
        //}

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

        //[HttpGet("/getFilmId/{firstname=string}/{lastname=string}")]
        //public short GetFilmId(string firstname, string lastname)
        //{
        //    try
        //    {
        //        short actor;
        //        using (var context = new sakilaContext())
        //        {
        //            actor = context.Actors.
        //                Where(a => a.FirstName.Equals(firstname) && (a.LastName.Equals(lastname))).
        //                Select(a => a.ActorId).
        //                First();
        //        }
        //        return actor;
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Actor with that name does not exist");
        //        return 0;
        //    }
        //}

        //[HttpPut("/setNewFilm/{firstname=string}/{lastname=string}")]
        //public void PutFilm(string firstname, string lastname)
        //{
        //    using (var context = new sakilaContext())
        //    {
        //        Actor actor = new Actor();
        //        actor.FirstName = firstname;
        //        actor.LastName = lastname;
        //        context.Actors.Add(actor);
        //        context.SaveChanges();
        //    }
        //}

        //[HttpPut("/updateExistingFilmName/{originalfirstname=string}/{originallastname=string}/{newfirstname=string}/{newlastname=string}")]    //what if there are multiple actors with the same first name? need to take into consideration the first and last
        //public Actor PutFilmName(string originalfirstname, string originallastname, string newfirstname, string newlastname)
        //{           
        //    try
        //    {
        //        using (var context = new sakilaContext())
        //        {
        //            Actor actor = context.Actors.
        //            Where(a => a.FirstName.Equals(originalfirstname) && (a.LastName.Equals(originallastname))).
        //            First();
        //            actor.FirstName = newfirstname;
        //            actor.LastName = newlastname;
        //            context.SaveChanges();
        //            return actor;
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Actor with that name does not exist");
        //        return null;
        //    }
        //}

        //[HttpDelete("/deleteFilm/{actorId:int}")]    //error handling for if the id does not exist
        //public void DeleteFilmName(int actorId)
        //{
        //    try
        //    {
        //        using (var context = new sakilaContext())
        //        {
        //            Actor actor = context.Actors.
        //                Where(a => a.ActorId.Equals((short)actorId)).
        //                First();
        //            context.Actors.Remove(actor);
        //            context.SaveChanges();
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Actor with that ID does not exist");
        //    }
        //}
    }
}