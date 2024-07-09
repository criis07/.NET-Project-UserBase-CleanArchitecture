using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateProject.Application.Endpoints.MarcasAutos;
using TemplateProject.Application.Interfaces.Persistence.DataServices.Users.Queries;


namespace TemplateProject.Infrastructure.Persistence.DataServices.MarcasAutoService
{
    public class MarcasAutosService : IMarcasAutosService
    {
        public Task<IEnumerable<MarcasAutos>> GetAllMarcasAutos()
        {
            throw new NotImplementedException();
        }
    }
}
