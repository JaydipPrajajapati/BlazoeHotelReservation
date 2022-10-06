using Blazor_Reservation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Reservation.Data
{
    public class BookingService
    {
        private readonly ApplicationDbContext _context;
        public BookingService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<List<Booking>> GetBookingList()
        {
            var bookings = await _context.Bookings.Include(a => a.Room).ToListAsync();
            return bookings;
        }

        public async Task<Booking?> GetBookingById(int id)
        {
            var booking = await _context.Bookings.Include(a => a.Room).FirstOrDefaultAsync(a => a.ID == id);
            return booking;
        }

        public async Task<int> AddBooking(Booking booking)
        {
            _context.Add(booking);
            await _context.SaveChangesAsync();
            return booking.ID;
        }

        public async Task UpdateBooking(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task DeleteBooking(int id)
        {
            try
            {

                var booking = new Booking { ID = id };
                _context.Remove(booking);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Boolean> IsBookingExist(Booking booking)
        {
            var existingBookings = await _context.Bookings.Include(a => a.Room).ToListAsync();
            if (existingBookings.Count > 0)
            {
                return existingBookings.Where(a => a.RoomID == booking.RoomID && a.ID != booking.ID && ((a.CheckIn <= booking.CheckIn && a.CheckOut >= booking.CheckIn) || (a.CheckIn <= booking.CheckOut && a.CheckIn >= booking.CheckOut))).Any();
            }
            return false;
        }
    }
}
