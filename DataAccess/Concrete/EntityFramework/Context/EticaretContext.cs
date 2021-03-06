using System.Reflection;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EticaretContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public EticaretContext(DbContextOptions<EticaretContext> dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var datas = ChangeTracker.Entries<BaseEntity>();
        //    foreach (var entry in datas)
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                ((BaseEntity)entry.Entity).CreatedDate = DateTime.Now;
        //                ((BaseEntity)entry.Entity).IsActive = true;
        //                break;

        //            case EntityState.Modified:
        //                ((BaseEntity)entry.Entity).UpdatedDate = DateTime.Now;
        //                break;

        //            case EntityState.Deleted:
        //                entry.State = EntityState.Modified;
        //                entry.CurrentValues["IsDeleted"] = true;
        //                break;
        //        }
        //    }
        //    return base.SaveChangesAsync(cancellationToken);
        //}

    }
}

