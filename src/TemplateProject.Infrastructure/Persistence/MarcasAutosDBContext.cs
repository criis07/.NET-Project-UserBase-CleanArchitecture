using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TemplateProject.Application.Endpoints.MarcasAutos.Queries;
using TemplateProject.Domain.Entities;

namespace TemplateProject.Infrastructure.Persistence
{
    public  class MarcasAutosDBContext : DbContext
    {
        public MarcasAutosDBContext(DbContextOptions<MarcasAutosDBContext> options)
            :base(options)
        {

        }
        public DbSet<MarcasAutos> MarcasAutos { get; set; }
    }
}
