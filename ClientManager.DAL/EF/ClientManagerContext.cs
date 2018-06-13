
using ClientManager.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ClientManager.DAL.EF

{
    public class ClientManagerContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }


        public ClientManagerContext(DbContextOptions<ClientManagerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}