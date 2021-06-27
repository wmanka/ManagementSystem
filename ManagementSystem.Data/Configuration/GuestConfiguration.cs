using ManagementSystem.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ManagementSystem.Data.Configuration
{
    public class GuestConfiguration : EntityTypeConfiguration<Guest>
    {
        public GuestConfiguration()
        {
            ToTable("Guests");
            HasKey(x => x.Id);

            Property(x => x.Name).IsRequired();
            Property(x => x.Surname).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.Id).IsRequired();

            Property(x => x.PostalCode).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
        }
    }
}
