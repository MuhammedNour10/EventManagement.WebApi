using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventManagement.WebApi.Data;
using Microsoft.AspNetCore.Identity;

namespace EventManagement.WebApi.Model;

public class Event
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    [MaxLength(100)]
    public string Location { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Time { get; set; }

    // Relationship: One user (Organizer) can create many events
    
    [Required]
    public string OrganizerId { get; set; }

    [ForeignKey("OrganizerId")]
    public ApplicationUser Organizer { get; set; }
    
    // Relationship: One event can have many RSVPs
    // public List<RSVP> RSVPs { get; set; } = new List<RSVP>();
}