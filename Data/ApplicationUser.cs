using Microsoft.AspNetCore.Identity;

namespace EventManagement.WebApi.Data;

public class ApplicationUser:IdentityUser
{

    public string FullName { get; set; }=string.Empty;
    
}