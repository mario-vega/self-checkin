using Dapper;
using Microsoft.Extensions.Configuration;
using self_checkin_api.Contracts;
using self_checkin_api.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace self_checkin_api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _dapperContext;

        public UserRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<User> GetUser(int id)
        {
            var query = "select top(1) * from [self-checkin].[dbo].[user];";
            using (var connection = _dapperContext.CreateConnection())
            {
                var user = await connection.QueryFirstAsync<User>(query);
                return user;
            }
        }
    }
}
