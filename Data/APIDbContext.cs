using dotrest.Model;
using Microsoft.EntityFrameworkCore;

namespace dotrest.Data;

public class APIDbContext : DbContext
{
    public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
    {

    }

    public DbSet<Department> Departments { get; set; }
    // public DbSet<Employee> Employees { get; set; }

}