using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using TemplateProject.Application.Endpoints.People;
using TemplateProject.Application.Endpoints.Users;
using TemplateProject.Application.Interfaces.Persistence.DataServices.Users.Queries;
using TemplateProject.Domain.Entities;
using TemplateProject.Infrastructure.Services;

namespace TemplateProject.Infrastructure.Persistence.DataServices.Users
{
    public class UserDataService : IUserDataService
    {
        private readonly MysqlConfigs _connectionStrings;

        public UserDataService(MysqlConfigs mysqlConfigs)
        {
            _connectionStrings = mysqlConfigs;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionStrings.ConnectionStrings);
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsers()
        {
            var db = dbConnection();
            var sql = @"SELECT * FROM Employee ORDER BY HireDate DESC";
            return await db.QueryAsync<UserViewModel>(sql, new { });
        }

    } 
}
