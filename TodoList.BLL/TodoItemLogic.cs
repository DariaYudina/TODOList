using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoList.Entities;
using TodoList.IBLL;
using TodoList.IDAL;

namespace TodoList.BLL
{
    internal class TodoItemLogic : ITodoItemLogic
    {
        private readonly ITodoItemDAO _todoItemDao;

        public TodoItemLogic(ITodoItemDAO todoItemDao)
        {
            _todoItemDao = todoItemDao;
        }
        public Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> GetTodoItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateTodoItemAsync(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodoItemAsync(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodoItemAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
