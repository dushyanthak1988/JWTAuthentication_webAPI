using AutoMapper;
using JWTAuthentication_webAPI.Data;
using JWTAuthentication_webAPI.Model;

namespace JWTAuthentication_webAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
