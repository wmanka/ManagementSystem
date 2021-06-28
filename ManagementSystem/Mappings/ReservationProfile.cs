using AutoMapper;
using ManagementSystem.Applications.Requests;
using ManagementSystem.Applications.Responses;
using ManagementSystem.Domain.Entities;

namespace ManagementSystem.Mappings
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<CreateReservationRequest, Reservation>();
            CreateMap<Reservation, ReservationResponse>();
        }
    }
}