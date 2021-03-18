using ApiJwt.Core.Models;
using AutoMapper;

namespace ApiJwt.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}