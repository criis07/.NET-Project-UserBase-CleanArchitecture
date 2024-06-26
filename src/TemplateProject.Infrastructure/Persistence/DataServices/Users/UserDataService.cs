using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateProject.Application.Interfaces.Persistence.DataServices.Users.Queries;
using TemplateProject.Domain.Entities;

namespace TemplateProject.Infrastructure.Persistence.DataServices.Users
{
    public class UserDataService : IUserDataService
    {
        public Task<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
