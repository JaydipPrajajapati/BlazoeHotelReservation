using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Reservation.Model
{
    public class Room
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int RoomTypeID { get; set; }
        public virtual RoomType RoomType { get; set; }

        public virtual List<Booking> Bookings { get; set; }

    }
}
