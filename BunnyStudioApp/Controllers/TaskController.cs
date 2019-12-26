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
namespace BunnyStudioApp.Controllers
{
    public class TaskController : ApiController
    {

        bunnyDBEntities dbEntities = new bunnyDBEntities();
        

        // GET api/values/5
        public IEnumerable<TaskWrapper> GetTasks(int id)
        { 
            return dbEntities.Tasks.Where(val => val.UserId == id).Select(val => new TaskWrapper
            {
                Id = val.Id,
                UserId = val.UserId,
                State = val.State,
                Description = val.Description,
                Selected = false
            }); 
        }

        // POST api/values
        public void Post(Task task)
        {
            dbEntities.Tasks.Add(task);
            dbEntities.SaveChanges();
        }

        // PUT api/values/5
        public void Put(Task task)
        {
            var existingTask = dbEntities.Tasks.Where(s => s.Id == task.Id)
                                                 .FirstOrDefault();
            if (existingTask != null)
            {
                existingTask.State = task.State;
                existingTask.Description = task.Description;
                dbEntities.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var task = dbEntities.Tasks.Where(s => s.Id == id).FirstOrDefault();
            if (task != null)
            {
                dbEntities.Tasks.Remove(task);
                dbEntities.SaveChanges();
            }
            
        }
    }
}
