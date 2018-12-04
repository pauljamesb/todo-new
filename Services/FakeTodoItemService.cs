using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{


      public class FakeTodoItemService : ITodoItemService
      {



            public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
            {
                // Return an array of these Items.
                IEnumerable<TodoItem> items = new[]
                {
                    new TodoItem
                    {
                        Title = "A title here",
                        DueAt = DateTimeOffset.Now.AddDays(1)
                    }
                };

                return Task.FromResult(items);

            }





      }


}
