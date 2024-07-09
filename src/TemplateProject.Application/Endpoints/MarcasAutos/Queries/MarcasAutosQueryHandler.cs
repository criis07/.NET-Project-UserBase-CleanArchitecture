using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TemplateProject.Application.Models;
using TemplateProject.Domain.Entities;

namespace TemplateProject.Application.Endpoints.MarcasAutos.Queries
{
    public class MarcasAutosQueryHandler : IRequestHandler<MarcasAutosQuery, EndpointResult<IEnumerable<MarcasAutos>>>
    {
        public Task<EndpointResult<IEnumerable<MarcasAutos>>> Handle(MarcasAutosQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
