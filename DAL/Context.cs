using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GQ26LQR\\SQLEXPRESS;initial catalog=CasgemAjaxDb;integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
