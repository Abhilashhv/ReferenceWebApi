using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ReferenceWebApi.Models;

namespace ReferenceWebApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions contextOptions):base(contextOptions)
        {
          
        }

        public DbSet<Course> Courses { get; set; }
    }
}
