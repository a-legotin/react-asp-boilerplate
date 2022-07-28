using AutoMapper;
using Identity.Core.Domain.Entities;
using Identity.Infrastructure.Identity;

namespace Identity.Infrastructure.Data.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<User, AppUser>().ConstructUsing(u => new AppUser {UserName = u.UserName, Email = u.Email}).ForMember(au=>au.Id,opt=>opt.Ignore());
            CreateMap<AppUser, User>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email)).
                                       ForMember(dest=> dest.PasswordHash, opt=> opt.MapFrom(src=>src.PasswordHash));
            

        }
    }
}
