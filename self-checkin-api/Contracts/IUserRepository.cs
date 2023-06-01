using self_checkin_api.Models;
using System.Threading.Tasks;

namespace self_checkin_api.Contracts
{
    public interface IUserRepository
    {
        public Task<User> GetUser(int id);
    }
}
