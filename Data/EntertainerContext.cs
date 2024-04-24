using Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final.Data;

public class EntertainerContext : IdentityDbContext
{
    public EntertainerContext(DbContextOptions<EntertainerContext> options)
        : base(options)
    {
    }
    public DbSet<Entertainer> Entertainers { get; set; }
    
}