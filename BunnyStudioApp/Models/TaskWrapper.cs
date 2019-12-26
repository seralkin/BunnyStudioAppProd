using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BunnyStudioApp.Models
{
    public class TaskWrapper
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public Boolean Selected { get; set; }
    }
}