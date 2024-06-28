using MediatR;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using TemplateProject.Application.Endpoints.People.Queries;
using TemplateProject.Api.Extensions;
using TemplateProject.Application.Endpoints.Users.Queries;

namespace TemplateProject.Api.Controllers
{
[ExcludeFromCodeCoverage]
[ApiController]
[Route("api/v{version:apiVersion}/users")]
[ApiVersion("1.0")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/users")]
        public async Task<ActionResult> GetUserAsync()
        {
            var request = new UserQuery(); // Crea una instancia por defecto de PeopleQuery
            var result = await _mediator.Send(request);
            return result.ToActionResult();
        }
    }

}
