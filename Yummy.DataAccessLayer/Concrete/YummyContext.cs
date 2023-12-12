using Microsoft.EntityFrameworkCore;
using Yummy.EntityLayer.Concrete;

namespace Yummy.DataAccessLayer.Concrete
{
	public class YummyContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=MSI;initial catalog=YummyDB;integrated security=true;trusted_connection=true;encrypt=false");
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}