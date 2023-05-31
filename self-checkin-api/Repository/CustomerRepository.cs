using Dapper;
using self_checkin_api.Contracts;
using self_checkin_api.Models;
using System.Threading.Tasks;

namespace self_checkin_api.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _context;

        public CustomerRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetCustomer(int id)
        {
            var query = "select top(1) * from [self-checkin].[dbo].[customer];";
            using (var connection = _context.CreateConnection())
            {
                var customer = await connection.QueryFirstAsync<Customer>(query);
                return customer;
            }
        }
    }
}
