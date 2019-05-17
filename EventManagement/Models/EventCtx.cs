using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventManagement.Models
{
    public class EventCtx:DbContext
    {
        public DbSet<Purohith> purohiths { get; set; }
        public DbSet<UserDetails> users { get; set; }
        public DbSet<Decorator> decorators { get; set; }
        public DbSet<Catering> caterings { get; set; }
    }
}