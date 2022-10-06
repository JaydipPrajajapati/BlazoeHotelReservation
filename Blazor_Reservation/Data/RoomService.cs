using Blazor_Reservation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Reservation.Data
{
    public class RoomService
    {
        private readonly ApplicationDbContext _context;
        public RoomService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<List<Room>> Get()
        {
            var rooms = await _context.Rooms.Include(a => a.RoomType).ToListAsync();
            return rooms;
        }

        public async Task<Room> Get(int id)
        {
            var room = await _context.Rooms.Include(a => a.RoomType).FirstOrDefaultAsync(a => a.ID == id);
            return room;
        }
    }
}
