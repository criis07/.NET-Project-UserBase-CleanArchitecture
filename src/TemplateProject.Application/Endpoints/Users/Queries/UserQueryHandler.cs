using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TemplateProject.Application.Endpoints.People.Queries;
using TemplateProject.Application.Endpoints.People;
using TemplateProject.Application.Models;
using AutoMapper;
using TemplateProject.Application.Interfaces.Persistence.DataServices.People.Queries;
using TemplateProject.Application.Interfaces.Persistence.DataServices.Users.Queries;

namespace TemplateProject.Application.Endpoints.Users.Queries
{
    public class UserQueryHandler : IRequestHandler<UserQuery, EndpointResult<IEnumerable<UserViewModel>>>
    {
        public readonly IUserDataService _userDataService;
        public readonly IMapper _mapper;

        public UserQueryHandler(IUserDataService userDataService, IMapper mapper)
        {
            _userDataService = userDataService;
            _mapper = mapper;
        }

        public async Task<EndpointResult<IEnumerable<UserViewModel>>> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            var users = await _userDataService.GetAllUsers();

            return new EndpointResult<IEnumerable<UserViewModel>>(_mapper.Map<UserViewModel[]>(users));
        }
    }
}
