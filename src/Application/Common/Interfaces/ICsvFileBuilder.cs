using Calculator.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Calculator.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
