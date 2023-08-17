using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Entities;
using TodoList.IDAL;

namespace TodoList.DAL
{
    internal class TodoItemEFDAO : ITodoItemDAO
    {
        private readonly TodoContext _context;

        public TodoItemEFDAO(TodoContext context)
        {
            _context = context;
        }
        public Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TodoItem> GetTodoItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateTodoItemAsync(TodoItem todoItem)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTodoItemAsync(TodoItem todoItem)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteTodoItemAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
