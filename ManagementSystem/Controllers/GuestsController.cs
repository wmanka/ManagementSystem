using ManagementSystem.Applications.QueryStrings;
using ManagementSystem.Domain.Constants;
using ManagementSystem.Services;
using System.Threading.Tasks;
using System.Web.Http;

namespace ManagementSystem.Controllers
{
    public class GuestsController : ApiController
    {
        private readonly IGuestsService _guestsService;

        public GuestsController(IGuestsService guestsService)
        {
            _guestsService = guestsService;
        }

        [HttpGet]
        [Route(ApiRoutes.Guests.GetAll)]
        public async Task<IHttpActionResult> GetAll(string name = null, string city = null)
        {
            var guests = await _guestsService.GetAllAsync(new GetAllGuestsQueryString(name, city));

            return Ok(guests);
        }
    }
}
