using TemplateProject.Application.Models;
using MediatR;

namespace TemplateProject.Application.Endpoints.People.Queries;

public class PeopleQuery : IRequest<EndpointResult<IEnumerable<PersonViewModel>>>
{
    public bool IncludeInactive { get; init; } = false;
}

