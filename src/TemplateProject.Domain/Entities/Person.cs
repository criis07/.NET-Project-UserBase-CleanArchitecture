using TemplateProject.Domain.Common;

namespace TemplateProject.Domain.Entities;

public class Person : AuditableEntity
{
    public int? Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public bool Active { get; set; }
}
