using System;
using System.Collections.Generic;

namespace ManagementSystem.Applications.Responses
{
    public class ReservationResponse
    {
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public decimal? CommissionFee { get; set; }
        public string Source { get; set; }

        public IEnumerable<GuestResponse> Guests { get; set; }
    }
}