using System.Threading.Tasks;
using ManagementSystem.Domain.Entities;
using System.Collections.Generic;
using ManagementSystem.Data;
using System.Data.Entity;
using System.Linq;
using ManagementSystem.Applications.QueryStrings;

namespace ManagementSystem.Services
{
    public class GuestsService : IGuestsService
    {
        private readonly DataContext _dataContext;

        public GuestsService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Guest>> GetAllAsync(GetAllGuestsQueryString query)
        {
            var guests = _dataContext.Guests.AsQueryable();

            guests = AddFiltersOnQuery(query, guests);

            return await guests.ToListAsync();
        }

        private static IQueryable<Guest> AddFiltersOnQuery(GetAllGuestsQueryString filter, IQueryable<Guest> guests)
        {
            if (filter?.Name != null)
            {
                guests = guests.Where(x => x.Name == filter.Name);
            }
            if (filter?.City != null)
            {
                guests = guests.Where(x => x.City == filter.City);
            }

            return guests;
        }
    }
}