using ManagementSystem.Applications.QueryStrings;
using ManagementSystem.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementSystem.Services
{
    public interface IGuestsService
    {
        Task<IEnumerable<Guest>> GetAllAsync(GetAllGuestsQueryString query);
    }
}
