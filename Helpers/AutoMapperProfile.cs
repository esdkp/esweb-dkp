using AutoMapper;
using DKP.Dtos;
using DKP.Data;

namespace DKP.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
