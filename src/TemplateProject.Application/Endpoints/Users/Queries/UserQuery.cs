using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TemplateProject.Application.Endpoints.People;
using TemplateProject.Application.Models;

namespace TemplateProject.Application.Endpoints.Users.Queries
{
    public class UserQuery : IRequest<EndpointResult<IEnumerable<UserViewModel>>>
    {
    }
}
