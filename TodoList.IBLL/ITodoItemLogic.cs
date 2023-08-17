using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.IBLL
{
    public interface ITodoItemLogic
    {
        Task<IEnumerable<TodoItem>> GetTodoItemsAsync();
        Task<TodoItem> GetTodoItemByIdAsync(int id);
        Task CreateTodoItemAsync(TodoItem todoItem);
        Task UpdateTodoItemAsync(TodoItem todoItem);
        Task DeleteTodoItemAsync(int id);
    }
}
