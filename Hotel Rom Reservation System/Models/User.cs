
using System.Collections.Generic;

namespace Hotel_Rom_Reservation_System.Models
{
    internal class User
    {
        public string UsernaName { get; set; }
        public string Password { get; set; }

        public List<int> BookingHistory { get; set; };
    }
}
