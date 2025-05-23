using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventManagement.WebApi.Data;
using Microsoft.AspNetCore.Identity;

namespace EventManagement.WebApi.Model;

public class RSVP
{
    // Composite key: UserId + EventId
    [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }

    [Required]
    public int EventId { get; set; }

    [ForeignKey("EventId")]
    public Event Event { get; set; }

    [Required]
    public RSVPStatus Status { get; set; }
}

public enum RSVPStatus
{
    Going,
    Maybe,
    NotGoing
}