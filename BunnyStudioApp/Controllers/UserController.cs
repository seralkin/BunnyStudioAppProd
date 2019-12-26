using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BunnyStudioApp.Models;
using System.Text;
using Newtonsoft.Json;
using System.Data.Entity;
using Microsoft.AspNetCore.Cors;



namespace BunnyStudioApp.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    public class UserController : ApiController
    {
        bunnyDBEntities dbEntities = new bunnyDBEntities();
        // GET api/values
        public IEnumerable<UserWrapper> GetUsers()
        {
                return dbEntities.Users.Select( val => new UserWrapper { Id = val.Id, Name=val.Name, Selected=false});
        }
    
        // POST api/values
        public void Post(User user)
        {
            dbEntities.Users.Add(user);
            dbEntities.SaveChanges();
        }

        // PUT api/values/5
        public void Put(User user)    
        {
            var existingUser = dbEntities.Users.Where(s => s.Id == user.Id)
                                    .FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                dbEntities.SaveChanges();
            }
           
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var userTasks = dbEntities.Tasks.Where(s => s.UserId == id).ToList();
            var existingUser = dbEntities.Users.Where(s => s.Id == id)
                                                 .FirstOrDefault();
            if (userTasks != null)
            {
                dbEntities.Tasks.RemoveRange(userTasks);
                dbEntities.SaveChanges();
            }
            if (existingUser != null)
            {
                dbEntities.Users.Remove(existingUser);
                dbEntities.SaveChanges();
            }
        }

    }
}
