using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using to_do2.Repositories.DTOs.Abstraction;

namespace to_do2.Repositories.DTOs
{
    public class TodoDTO : DTO
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime Date { get; set; }


    }
}
