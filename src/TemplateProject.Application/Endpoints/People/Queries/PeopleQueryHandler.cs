using AutoMapper;
using TemplateProject.Application.Interfaces.Persistence.DataServices.People.Queries;
using TemplateProject.Application.Models;
using MediatR;

namespace TemplateProject.Application.Endpoints.People.Queries;

public class PeopleQueryHandler : IRequestHandler<PeopleQuery, EndpointResult<IEnumerable<PersonViewModel>>>
{
    public readonly IGetPeopleDataService _getPeopleDataService;
    public readonly IMapper _mapper;

    public PeopleQueryHandler(IGetPeopleDataService getPeopleDataService, IMapper mapper)
    {
        _getPeopleDataService = getPeopleDataService;
        _mapper = mapper;
    }

    public async Task<EndpointResult<IEnumerable<PersonViewModel>>> Handle(PeopleQuery request, CancellationToken cancellationToken = default)
    {
        var people = await _getPeopleDataService.ExecuteAsync(request.IncludeInactive, cancellationToken);

        return new EndpointResult<IEnumerable<PersonViewModel>>(_mapper.Map<PersonViewModel[]>(people));
    }
}
