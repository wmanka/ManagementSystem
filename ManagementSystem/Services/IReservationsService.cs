using ManagementSystem.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementSystem.Services
{
    public interface IReservationsService
    {
        Task<IEnumerable<Reservation>> GetAllAsync();
        Task<Reservation> CreateAsync(Reservation reservation);
        Task<Reservation> GetAsync(int reservationId);
    }
}
