using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using to_do2.Repositories.DTOs.Abstraction;
using to_do2.Object_Relational_Mapping;
using System.Collections.Generic;
using to_do2.Object_Mapper;


namespace to_do2.Repositories.Repositories.Abstraction
{
    public class Repository
    {

        private readonly ToDoContext _todoDbContext;

        public Repository(ToDoContext todoDbContext)
        {

            _todoDbContext = todoDbContext;

        }

        public async Task<ActionResult<TDto>> add<TDto, TRepositorymodel>(TDto postDTO) where TDto : DTO, new() where TRepositorymodel : DbContext, new()
        {

            TRepositorymodel repositoryModel = ModalMappingHelper.MapModals<TDto, TRepositorymodel>(postDTO);
            TDto dataTransferObject = ModalMappingHelper.MapModals<TRepositorymodel, TDto>(repositoryModel);

            await _todoDbContext.AddAsync<TRepositorymodel>(repositoryModel);
            await _todoDbContext.SaveChangesAsync();

            return dataTransferObject;

        }

       


    }
}
