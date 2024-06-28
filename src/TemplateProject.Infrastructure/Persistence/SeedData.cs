using TemplateProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TemplateProject.Infrastructure.Persistence;

public static class SeedDataExtension
{
    public static void SeedData(this ModelBuilder builder)
    {
        // TODO: Use this file to seed the database with any initial data that
        // should exist the first time the application is run.

        builder.Entity<User>().HasData(
            new User { EmployeeFirstName = "Juan", EmployeeLastName = "Rodriguez", EmployeePhone = "81921034", HireDate = DateTime.UtcNow, EmployeeZip = "12345" }
        );
    }
}
