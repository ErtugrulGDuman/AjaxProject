using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EGD\\SQLEXPRESS;initial Catalog=AjaxProject;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
