using EntityFrameworkSqlServer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlServer.DataContext
{
    class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<UserRole> userRoles { get; set; }

        public UserContext() : base("name=LocalDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasOptional<UserRole>(user => user.userRole).WithMany(role => role.users).HasForeignKey(user => user.RoleId).WillCascadeOnDelete();
        }
    }
}
