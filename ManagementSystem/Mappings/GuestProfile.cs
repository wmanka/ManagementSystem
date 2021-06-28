using AutoMapper;
using ManagementSystem.Applications.Requests;
using ManagementSystem.Applications.Responses;
using ManagementSystem.Domain.Entities;

namespace ManagementSystem.Mappings
{
    public class GuestProfile : Profile
    {
        public GuestProfile()
        {
            CreateMap<GuestRequest, Guest>();
            CreateMap<Guest, GuestResponse>();
        }
    }
}