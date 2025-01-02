using CRM.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Server.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

    }
}
