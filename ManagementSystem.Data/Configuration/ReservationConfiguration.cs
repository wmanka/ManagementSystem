using ManagementSystem.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ManagementSystem.Data.Configuration
{
    public class ReservationConfiguration : EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            ToTable("Reservations");
            HasKey(x => x.Id);

            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.CheckInDate).IsRequired();
            Property(x => x.CheckOutDate).IsRequired();
            Property(x => x.Code).IsRequired();
            Property(x => x.Currency).IsRequired();
            Property(x => x.Id).IsRequired();
            Property(x => x.Price).IsRequired();

            Property(x => x.CommissionFee).IsOptional();
            Property(x => x.Source).IsOptional();

            Property(x => x.Code).HasMaxLength(10);

            HasMany(g => g.Guests)
                .WithMany(r => r.Reservations)
                .Map(gr =>
                {
                    gr.MapLeftKey("ReservationId");
                    gr.MapRightKey("GuestId");
                    gr.ToTable("GuestsReservations");
                });
        }
    }
}
