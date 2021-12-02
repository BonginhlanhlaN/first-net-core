using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using to_do2.Repositories.DTOs;
using to_do2.Repositories.Repositories.Abstraction;
using to_do2.Repositories.Models;

namespace to_do2.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {

        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {

            _todoRepository = todoRepository;

        }

        [HttpPost]
        [Route("AddTodo")]
        public async Task<ActionResult<TodoDTO>> AddTodo([FromBody] TodoDTO todoDTO)
        {

            var todoDTOTask = await _todoRepository.add<TodoDTO, ToDo>(todoDTO);
            return Ok(todoDTOTask);

        }//dotnet ef database update

    }
}
