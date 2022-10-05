using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ViewComponentRazorPage.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
