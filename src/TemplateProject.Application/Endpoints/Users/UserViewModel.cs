using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProject.Application.Endpoints.Users
{
    public record UserViewModel
    {
        public int EmployeeId { get; set; }
        public string? EmployeeLastName { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeePhone { get; set; }
        public string? EmployeeZip { get; set; }
        public DateTime HireDate { get; set; }
    }
}
