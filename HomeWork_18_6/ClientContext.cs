using System.Data.Entity;

namespace HomeWork_18_6
{
    class ClientContext : DbContext
    {
        public ClientContext(): base("DbConnection") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ContactData> CcontactDate { get; set; }

    }
}
