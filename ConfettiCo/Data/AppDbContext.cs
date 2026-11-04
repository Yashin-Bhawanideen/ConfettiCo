using ConfettiCo.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfettiCo.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Enquiry> Enquiries => Set<Enquiry>();
}
