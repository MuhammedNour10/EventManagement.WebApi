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
    
    
    public class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Event
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.Include(x=>x.Organizer).ToListAsync();
        }

        // GET: api/Event/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var @event = await _context.Events.Include(x=>x.Organizer)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (@event == null)
            {
                return NotFound();
            }

            return @event;
        }

        // PUT: api/Event/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(int id, Event @event)
        {
            
            var user=await _context.Users.FindAsync(@event.OrganizerId);
            if (user == null)
            {
                return NotFound();
            }
            
            if (id != @event.Id)
            {
                return BadRequest();
            }
            
            @event.OrganizerId = @event.OrganizerId;

            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Event
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(string title,string description,string location,DateTime date,string organizerId,string time)
        {

            var user = await _context.Users.FindAsync(organizerId);

            var createEvent = new Event
            {
                Title = title,
                Description = description,
                Location = location,
                Date = date,
                Time = time,
                OrganizerId = organizerId
            };

            if (user == null)
            {
                return BadRequest("No user found");
            }

            createEvent.Organizer = user;
            
            await _context.Events.AddAsync(createEvent);
            
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent", new { id = createEvent.Id }, createEvent);
        }

        // DELETE: api/Event/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
