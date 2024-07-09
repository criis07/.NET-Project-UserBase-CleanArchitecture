using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProject.Application.Endpoints.MarcasAutos
{
    public record MarcasAutos
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
    }
}
