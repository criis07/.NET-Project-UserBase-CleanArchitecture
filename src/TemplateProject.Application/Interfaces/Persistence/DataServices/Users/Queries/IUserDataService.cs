using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateProject.Domain.Entities;

namespace TemplateProject.Application.Interfaces.Persistence.DataServices.Users.Queries
{
    public interface IUserDataService
    {
        Task<User> GetUsers();
    }
}
