﻿using Bussines.DTO;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public interface ITodoService
    {
        Task<List<TodoDto>> GetAllTodos();
        Task<TodoDto> GetByIdTodo(int id);
        Task<bool> SaveTodo(TodoDto todo);
        Task<bool> UpdatedTodo(TodoDto todoDto);
        Task<bool> DeleteTodo(int id);
        Task<List<TodoDto>> GetUserTodos(int id);

    }
}
