using TemplateProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TemplateProject.Application.Interfaces.Persistence;

public interface IApplicationDbContext
{
    DbSet<Person> People { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
