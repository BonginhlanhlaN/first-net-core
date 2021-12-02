using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using to_do2.Repositories.Models;

namespace to_do2.Object_Relational_Mapping
{
    public class ToDoContext : DbContext
    {

        public ToDoContext(DbContextOptions<ToDoContext> toDoContextOptions) : base(toDoContextOptions)
        {

        }

        public DbSet<ToDo> Todos { get; set; }

    }
}
