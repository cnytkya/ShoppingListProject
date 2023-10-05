using Microsoft.EntityFrameworkCore;
using ShoppingListProject.Entitylayer;
using ShoppingListProject.EntityLayer;
using System.Reflection;

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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // FluentAPI : Data annotations taki tablo ve property özelliklerini yapılandırabileceğimiz bir diğer yöntemdir.
        //    modelBuilder.Entity<User>().Property(a => a.FirstName) // Entitilerimizden user ın propertylerinden Name alanı için 
        //        .IsRequired() // Bu property i zorunlu alan yap
        //        .HasColumnType("varchar(50)") // Name alanının sql deki kolon tipi varchar(50) olsun
        //        .HasMaxLength(50) // Kolon karakter uzuluğu
        //        ;
        //    modelBuilder.Entity<User>().Property(s => s.FirstName).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
        //    modelBuilder.Entity<User>().Property(s => s.LastName).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
        //    modelBuilder.Entity<User>().Property(s => s.Email).IsRequired().HasColumnType("nvarchar(50)");
        //    //modelBuilder.Entity<User>().Property(un => un.Username).HasColumnType("nvarchar(50)");
        //    modelBuilder.Entity<User>().Property(p => p.Password).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
        //    // FluentAPI ile veritabanı oluştuktan sonra ilk kaydı ekleme
        //    modelBuilder.Entity<User>().HasData(
        //        new User
        //        {
        //            UserId = 1,
        //            FirstName = "Admin",
        //            Password = "123",
        //            Email = "admin@gmail.com",
        //            IsActive = true,
        //            IsAdmin = true,
        //            //Name = "Admin",
        //            //Surname = "Administrator"
        //        });
            

        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Otomatik olarak projedeki tüm configurationları ekliyor.

        //    base.OnModelCreating(modelBuilder);
        //}


    }
}
