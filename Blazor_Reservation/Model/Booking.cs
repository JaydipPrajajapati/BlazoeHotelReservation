using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Reservation.Model
{
    public class Booking
    {
        public int ID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please Select a Room")]
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please Enter No Of Guest")]
        public int Guests { get; set; }
        public decimal TotalFee { get; set; }
        public bool Paid { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

    }

    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string City { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
