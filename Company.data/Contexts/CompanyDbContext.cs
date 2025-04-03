using System.Reflection;
using Company.data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Company.data.Contexts
{
    public class CompanyDbContext : IdentityDbContext<ApplicationUser>
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<IdentityUserLogin<string>>()
            .HasKey(i => new { i.LoginProvider, i.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasKey(i => new { i.UserId, i.RoleId });

            modelBuilder.Entity<IdentityUserToken<string>>()
            .HasKey(i => new { i.UserId, i.LoginProvider, i.Name });
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
