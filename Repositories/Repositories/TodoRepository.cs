using to_do2.Repositories.Repositories.Abstraction;
using to_do2.Object_Relational_Mapping;

namespace to_do2.Repositories.Repositories
{
    public class TodoRepository : Repository, ITodoRepository
    {

        private readonly ToDoContext _todoDbContext;

        public TodoRepository(ToDoContext todoDbContext) : base(todoDbContext)
        {



        }

    }
}
