using Calculator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<CalculatorResult> CalculatorResult { get; set; }

        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
