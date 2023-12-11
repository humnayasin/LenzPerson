using LenzPerson.api.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace LenzPerson.api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
    }

}
