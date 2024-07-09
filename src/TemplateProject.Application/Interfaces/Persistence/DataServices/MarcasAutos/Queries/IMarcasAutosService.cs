using TemplateProject.Application.Endpoints.MarcasAutos;
using TemplateProject.Application.Endpoints.Users;

namespace TemplateProject.Application.Interfaces.Persistence.DataServices.Users.Queries
{
    public interface IMarcasAutosService
    {
        Task<IEnumerable<MarcasAutos>> GetAllMarcasAutos();
    }
}
