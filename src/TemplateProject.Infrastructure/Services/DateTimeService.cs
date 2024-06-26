using System.Diagnostics.CodeAnalysis;
using TemplateProject.Application.Interfaces.Services;

namespace TemplateProject.Infrastructure.Services;

[ExcludeFromCodeCoverage]
public class DateTimeService : IDateTimeService
{
    public DateTime UtcNow => DateTime.UtcNow;
}
