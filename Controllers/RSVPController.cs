using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManagement.WebApi.Data;
using EventManagement.WebApi.Model;
using Microsoft.AspNetCore.Authorization;

namespace EventManagement.WebApi.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class RSVPController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RSVPController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("EventAttendees")]
        public async Task<ActionResult<IEnumerable<object>>> GetEventAttendees(int eventId)
        {
            var rsvps = await _context.RSVPs.Where(x => x.EventId == eventId).ToListAsync();

        // Get list of userIds from the rsvps
            var userIds = rsvps.Select(r => r.UserId).Distinct().ToList();

          // Fetch users based on userIds
            var users = await _context.Users.Where(u => userIds.Contains(u.Id)).ToListAsync();

           // Return both RSVP and user data if needed
            return Ok(new { RSVPs = rsvps, Users = users });

        }





        [HttpGet("userAttendeesEvent")]
        public async Task<bool> GetUserAttendeesEvent(int eventId, string userId)
        {
            return await _context.RSVPs.AnyAsync(x => x.EventId == eventId && x.UserId == userId);
        }


   



       

       
        // POST: api/RSVP
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AttendedEvent/{userId}/{eventId}/{status}")]
        public async Task<ActionResult<RSVP>> PostRSVP(string userId, int eventId,string status)
        {
            
            // 1. Validate the status string (Going, Maybe, NotGoing)
            if (!Enum.TryParse<RSVPStatus>(status, true, out var parsedStatus))
            {
                return BadRequest("Invalid RSVP status.");
            }

            // 2. Check if RSVP already exists
            var existingRSVP = await _context.RSVPs.FindAsync(userId, eventId);
            var user = await _context.Users.FindAsync(userId);
            var events=await _context.Events.FindAsync(eventId);
            if (existingRSVP != null)
            {
                // 3. Update existing RSVP
                existingRSVP.Status = parsedStatus;
                _context.RSVPs.Update(existingRSVP);
            }
            else
            {
                // 4. Create new RSVP
                var newRSVP = new RSVP
                {
                    UserId = userId,
                    EventId = eventId,
                    Status = parsedStatus,
                    User = user,
                    Event = events
                };
                await _context.RSVPs.AddAsync(newRSVP);
            }

            // 5. Save changes
            await _context.SaveChangesAsync();

            // 6. Return success response
            return Ok("RSVP saved successfully.");
        
        }

        
    }
}
