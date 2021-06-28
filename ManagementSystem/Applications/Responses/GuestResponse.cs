using System;

namespace ManagementSystem.Applications.Responses
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}