namespace ManagementSystem.Domain.Constants
{
    public static class ApiRoutes
    {
        public const string Base = "api";

        public static class Guests
        {
            public const string GetAll = Base + "/guests";
            public const string Get = Base + "/guests/{guestId}";
        }

        public static class Reservations
        {
            public const string GetAll = Base + "/reservations";
            public const string Get = Base + "/reservations/{reservationId}";
            public const string Create = Base + "/reservations";
        }
    }
}
