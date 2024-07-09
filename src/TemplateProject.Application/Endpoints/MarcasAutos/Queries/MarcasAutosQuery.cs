using MediatR;
using TemplateProject.Domain.Entities;
using TemplateProject.Application.Models;

namespace TemplateProject.Application.Endpoints.MarcasAutos.Queries
{
    public class MarcasAutosQuery : IRequest<EndpointResult<IEnumerable<MarcasAutos>>>
    {

    }
}
