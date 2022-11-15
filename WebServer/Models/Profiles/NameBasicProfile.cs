using AutoMapper;
using CITP_Portfolio_Subproject_2.DataLayer.Domain;

namespace WebServer.Models.Profiles
{
    public class NameBasicProfile : Profile
    {
        public NameBasicProfile()
            {
            CreateMap<nameBasic, NameBasicModel>();
            }
     
    }

    
}