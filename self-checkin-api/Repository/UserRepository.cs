using Microsoft.Extensions.Configuration;
using self_checkin_api.Contracts;
using System.Data.SqlClient;

namespace self_checkin_api.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            
        }

        public void GetUser(string username)
        {
            using (var connection = new SqlConnection())
            {

            }
        }
    }
}
