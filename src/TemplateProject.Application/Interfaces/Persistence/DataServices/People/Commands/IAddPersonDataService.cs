using TemplateProject.Domain.Entities;

namespace TemplateProject.Application.Interfaces.Persistence.DataServices.People.Commands;

public interface IAddPersonDataService
{
    Task<Person> ExecuteAsync(Person person, CancellationToken cancellationToken = default);
}

