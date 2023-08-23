using Micro.User.Entities;
using Micro.User.Services.Contracts;

namespace Micro.User.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _configuration;
        public UserService(IConfiguration configuration) {
            _configuration = configuration;
        }
        public UserE GetUser(int id)
        {
            var user = new UserE() ;
            try
            {
                var listUsr = _configuration.GetSection("Users").Get<List<UserE>>();
                if (listUsr != null)
                {
                    user = listUsr.Find(x => x.Id == id)!;
                }
               
            } catch (Exception) {
                throw;
            }
            return  user;
        }

    }
}
