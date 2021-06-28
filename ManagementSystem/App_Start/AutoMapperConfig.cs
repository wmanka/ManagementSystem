using AutoMapper;
using ManagementSystem.Mappings;
namespace ManagementSystem.App_Start
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; set; }

        public static void RegisterMappings()
        {
            var mapperConfiguration = new MapperConfiguration(
               config =>
               {
                   config.AddProfile<ReservationProfile>();
                   config.AddProfile<GuestProfile>();
               });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}