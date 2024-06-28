using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProject.Infrastructure.Services
{
    public class MysqlConfigs
    {
        public MysqlConfigs(string connectionStrings)
        {
            ConnectionStrings = connectionStrings;
        }

        public string ConnectionStrings { get; set; }
    }
}
