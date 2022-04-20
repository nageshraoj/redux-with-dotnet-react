using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StudentContext : DbContext
{

    public StudentContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Student> students { get; set; }


}