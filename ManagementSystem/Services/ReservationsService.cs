using ManagementSystem.Data;
using ManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ManagementSystem.Services
{
    public class ReservationsService : IReservationsService
    {
        private readonly DataContext _dataContext;

        public ReservationsService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await _dataContext.Reservations.Include(x => x.Guests).ToListAsync();
        }

        public async Task<Reservation> CreateAsync(Reservation reservation)
        {
            reservation.CreatedAt = DateTime.UtcNow;

            _dataContext.Reservations.Add(reservation);
            await _dataContext.SaveChangesAsync();

            return reservation;
        }

        public async Task<Reservation> GetAsync(int reservationId)
        {
            return await _dataContext.Reservations
                .Include(x => x.Guests)
                .SingleOrDefaultAsync(x => x.Id == reservationId);
        }

    }
}