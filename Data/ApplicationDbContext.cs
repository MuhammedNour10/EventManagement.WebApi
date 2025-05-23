using EventManagement.WebApi.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.WebApi.Data;

public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    
    
    public DbSet<Event> Events { get; set; }
    
    public DbSet<RSVP> RSVPs { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // One-to-Many: A user can create multiple events
        builder.Entity<Event>()
            .HasOne(e => e.Organizer)
            .WithMany()
            .HasForeignKey(e => e.OrganizerId)
            .OnDelete(DeleteBehavior.Restrict);

        // One-to-Many: An event can have multiple RSVPs
        builder.Entity<RSVP>()
            .HasOne(r => r.Event)
            .WithMany()
            .HasForeignKey(r => r.EventId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        builder.Entity<RSVP>()
            .HasKey(r => new { r.UserId, r.EventId }); // 👈 المفتاح المركب

        //RSVS
        var rsvs = new List<RSVP>()
        {
            new RSVP()
            {
               
                UserId = "043d41f5-929a-4e4d-b23a-d288d16eb967",
                EventId = 2,
                Status = 0,
            },
            new RSVP()
            {
               
                UserId = "043d41f5-929a-4e4d-b23a-d288d16eb967",
                EventId = 3,
                Status=0
            },
            new RSVP()
            {
             
                UserId = "043d41f5-929a-4e4d-b23a-d288d16eb967",
                EventId = 6,
                Status = 0,
            },
        };
        builder.Entity<RSVP>().HasData(rsvs);
       
         //Create  for our System
        var adminRolesID=Guid.NewGuid().ToString();
        var usersRoleID=Guid.NewGuid().ToString();
        var roles = new List<IdentityRole>
        { 
            new IdentityRole() { Id = adminRolesID, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = adminRolesID },
            new IdentityRole() { Id = usersRoleID, Name = "User", NormalizedName = "USER", ConcurrencyStamp = usersRoleID }

        };
        
        builder.Entity<IdentityRole>().HasData(roles);
        
        // 2️⃣ إنشاء المستخدمين
var applicationUsers = new List<ApplicationUser>
{
    new ApplicationUser
    {
        Id = "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
        UserName = "use1@gmail.com",
        NormalizedUserName = "USER1@GMAIL.COM",
        Email = "use1@gmail.com",
        NormalizedEmail = "USER1@GMAIL.COM",
        EmailConfirmed = true,
        ConcurrencyStamp = Guid.NewGuid().ToString(),
        LockoutEnabled = true,
        SecurityStamp = Guid.NewGuid().ToString(),
    },
    new ApplicationUser
    {
        Id = "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
        UserName = "user2@gmail.com",
        NormalizedUserName = "USER2@GMAIL.COM",
        Email = "user2@gmail.com",
        NormalizedEmail = "USER2@GMAIL.COM",
        EmailConfirmed = true,
        ConcurrencyStamp = Guid.NewGuid().ToString(),
        LockoutEnabled = true,
        SecurityStamp = Guid.NewGuid().ToString(),
    },
    new ApplicationUser
    {
        Id = "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
        UserName = "user3@gmail.com",
        NormalizedUserName = "USER3@GMAIL.COM",
        Email = "user3@gmail.com",
        NormalizedEmail = "USER3@GMAIL.COM",
        EmailConfirmed = true,
        ConcurrencyStamp = Guid.NewGuid().ToString(),
        LockoutEnabled = true,
        SecurityStamp = Guid.NewGuid().ToString(),
    },
    new ApplicationUser
    {
        Id = "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
        UserName = "user4@gmail.com",
        NormalizedUserName = "USER4@GMAIL.COM",
        Email = "user4@gmail.com",
        NormalizedEmail = "USER4@GMAIL.COM",
        EmailConfirmed = true,
        ConcurrencyStamp = Guid.NewGuid().ToString(),
        LockoutEnabled = true,
        SecurityStamp = Guid.NewGuid().ToString(),
    },
    new ApplicationUser
    {
        Id = "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
        UserName = "user5@gmail.com",
        NormalizedUserName = "USER5@GMAIL.COM",
        Email = "user5@gmail.com",
        NormalizedEmail = "USER5@GMAIL.COM",
        EmailConfirmed = true,
        ConcurrencyStamp = Guid.NewGuid().ToString(),
        LockoutEnabled = true,
        SecurityStamp = Guid.NewGuid().ToString(),
    },
    new ApplicationUser
    {
        Id = "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
        UserName = "user6@gmail.com",
        NormalizedUserName = "USER6@GMAIL.COM",
        Email = "user6@gmail.com",
        NormalizedEmail = "USER6@GMAIL.COM",
        EmailConfirmed = true,
        ConcurrencyStamp = Guid.NewGuid().ToString(),
        LockoutEnabled = true,
        SecurityStamp = Guid.NewGuid().ToString(),
    }
};

var adminAccount = new ApplicationUser
{
    Id = "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
    UserName = "admin@gmail.com",
    NormalizedUserName = "ADMIN@GMAIL.COM",
    Email = "admin@gmail.com",
    NormalizedEmail = "ADMIN@GMAIL.COM",
    EmailConfirmed = true,
    ConcurrencyStamp = Guid.NewGuid().ToString(),
    LockoutEnabled = true,
    SecurityStamp = Guid.NewGuid().ToString(),
};

// 3️⃣ توليد كلمات المرور
var passwordHasher = new PasswordHasher<ApplicationUser>();

adminAccount.PasswordHash=passwordHasher.HashPassword(adminAccount, "Admin@123");

builder.Entity<ApplicationUser>().HasData(adminAccount);


var adminRole = new IdentityUserRole<string>
{
    UserId = adminAccount.Id,
    RoleId = adminRolesID

};

builder.Entity<IdentityUserRole<string>>().HasData(adminRole);

foreach (var user in applicationUsers)
{
    user.PasswordHash = passwordHasher.HashPassword(user, "User@123");
}

// 4️⃣ إضافة المستخدمين إلى قاعدة البيانات
builder.Entity<ApplicationUser>().HasData(applicationUsers);

// 5️⃣ ربط المستخدمين بدور "Hospital"
var eventManagentUserRoles = applicationUsers.Select(user => new IdentityUserRole<string>
{
    UserId = user.Id,
    RoleId = usersRoleID
}).ToList();

builder.Entity<IdentityUserRole<string>>().HasData(eventManagentUserRoles);
        
        
    }
    
}