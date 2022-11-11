using Microsoft.AspNetCore.Mvc;
using Zedcrest_Task.DTO;

namespace Zedcrest_Task.Repository.Interface
{
    public interface IUserRepository
    {

        Task<UserRegistrationDTO> GetUserbyId(string id);

        //Task<UserRegistrationDTO> GetUserbyEmail(string email);
        Task<UserRegistrationDTO> GetUserbyUsername(string username);
        Task<UserRegistrationDTO> RegisterUser(UserRegistrationDTO userRegistrationDTO);
        Task<UserRegistrationDTO> UpdateUser(UserRegistrationDTO userRegistrationDTO);
        Task DeleteUser(string id);
        Task<UserLoginDTO> LoginUser(UserLoginDTO userLoginDTO);
    }
}
