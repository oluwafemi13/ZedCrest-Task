using AutoMapper;
using Zedcrest_Task.DTO;
using Zedcrest_Task.Models;

namespace Zedcrest_Task.MapperConfiguration
{
    public class Mappings: Profile
    {
        public Mappings()
        {
            CreateMap<UserRegistrationDTO, User>().ReverseMap();
            CreateMap<Wallet, WalletDTO>().ReverseMap();


        }
    }
}
