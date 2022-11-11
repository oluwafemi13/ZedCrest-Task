using Zedcrest_Task.Data;
using Zedcrest_Task.DTO;
using Zedcrest_Task.Models;
using Zedcrest_Task.Repository.Interface;

namespace Zedcrest_Task.Repository
{
    public class UserRepository : IUserRepository
    {
        //private readonly IUserRepository _userRepository;
        private readonly DatabaseContext _DatabaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _DatabaseContext = databaseContext;
        }
        public async Task DeleteUser(string id)
        {
             _DatabaseContext.Remove(id);

        }

        /*public async Task<IEnumerable<UserRegistrationDTO>> GetUserbyEmail(string email)
        {
            throw new NotImplementedException();

        }
*/
        public Task<UserRegistrationDTO> GetUserbyId(string id)
        {
            throw new NotImplementedException();
        }

        public Task<UserRegistrationDTO> GetUserbyUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Task<UserLoginDTO> LoginUser(UserLoginDTO userLoginDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserRegistrationDTO> RegisterUser(UserRegistrationDTO userRegistrationDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserRegistrationDTO> UpdateUser(UserRegistrationDTO userRegistrationDTO)
        {
            throw new NotImplementedException();
        }

        
    }
}
