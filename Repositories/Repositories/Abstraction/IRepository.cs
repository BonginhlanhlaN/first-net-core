using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using to_do2.Repositories.DTOs.Abstraction;

namespace to_do2.Repositories.Repositories.Abstraction
{
    public interface IRepository
    {

        public Task<ActionResult<TDto>> add<TDto, TRepositorymodel>(TDto postDTO) where TDto : DTO, new() where TRepositorymodel : DbContext, new();

    }
}
