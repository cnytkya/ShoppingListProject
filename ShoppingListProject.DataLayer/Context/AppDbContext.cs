using Microsoft.EntityFrameworkCore;
using ShoppingListProject.Entitylayer;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.DataLayer.Context
{
    public class AppDbContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDb;Database=ShoppingListProjectDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

  //      public AppDbContext(DbContextOptions options) : base(options)
		//{
		//}

		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ShoppingList> ShoppingLists { get; set; }
		public DbSet<ShoppingListItem> ShoppingListItems { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Notification> Notifications { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database= ShoppingListProjectDb;Trusted_Connection=True;TrustServerCertificate=True");
        //    }
        //}

    }
}
