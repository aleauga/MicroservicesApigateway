using Micro.User.Entities;

namespace Micro.User.Services.Contracts
{
    public interface IUserService
    {
        UserE GetUser(int id);
    }
}
