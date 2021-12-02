using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace to_do2.Repositories.Models
{
    public class ToDo : DbContext
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime Date { get; set; }
        //public string Secret { get; set; }

    }
}
