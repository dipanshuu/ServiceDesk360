using Microsoft.EntityFrameworkCore;
using WebApplicationProject27July.Models;

namespace WebApplicationProject27July.Context
{
    public class ClientDbContext : DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
        {

        }
        public DbSet<Client> Client { get; set; }
    }
}