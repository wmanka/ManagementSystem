using ManagementSystem.App_Start;
using ManagementSystem.Applications.Requests;
using ManagementSystem.Applications.Responses;
using ManagementSystem.Domain.Constants;
using ManagementSystem.Domain.Entities;
using ManagementSystem.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace ManagementSystem.Controllers
{
    public class ReservationsController : ApiController
    {
        private readonly IReservationsService _reservationsService;

        public ReservationsController(IReservationsService reservationService)
        {
            _reservationsService = reservationService;
        }

        [HttpGet]
        [Route(ApiRoutes.Reservations.GetAll)]
        public async Task<IHttpActionResult> GetAll()
        {
            var reservations = await _reservationsService.GetAllAsync();

            return Ok(AutoMapperConfig.Mapper.Map<IEnumerable<ReservationResponse>>(reservations));
        }

        [HttpPost]
        [Route(ApiRoutes.Reservations.Create)]
        public async Task<IHttpActionResult> Create([FromBody] CreateReservationRequest request)
        {
            var response = await _reservationsService.CreateAsync(AutoMapperConfig.Mapper.Map<Reservation>(request));

            return Created(ApiRoutes.Reservations.Get.Replace("{reservationId}", response.Id.ToString()),
                AutoMapperConfig.Mapper.Map<ReservationResponse>(response));
        }

        [HttpGet]
        [Route(ApiRoutes.Reservations.Get)]
        public async Task<IHttpActionResult> Get(int reservationId)
        {
            var response = await _reservationsService.GetAsync(reservationId);

            return Ok(AutoMapperConfig.Mapper.Map<ReservationResponse>(response));
        }
    }
}
