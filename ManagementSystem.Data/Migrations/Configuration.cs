namespace ManagementSystem.Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ManagementSystem.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManagementSystem.Data.DataContext context)
        {
            context.Reservations.AddOrUpdate(new Reservation
            {
                CheckInDate = new DateTime(2021, 6, 26),
                CheckOutDate = new DateTime(2021, 6, 29),
                Code = "ABC123",
                Currency = "PLN",
                CreatedAt = new DateTime(2021, 6, 20),
                Price = 500,
                Guests = new List<Guest> {
                    new Guest() { BirthDate = new DateTime(1990, 3, 21), Email = "jankowalski@email.com", Name = "Jan", Surname = "Kowalski", PostalCode = "12-345" },
                    new Guest() { BirthDate = new DateTime(1984, 10, 12), Email = "annakowalska@email.com", Name = "Anna", Surname = "Kowalska", PostalCode = "12-345" }}
            });

            context.SaveChanges();
        }
    }
}
