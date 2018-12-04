// Got to page 27

using System.Collections.Generic;

namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Items { get; set; }
    }
}
