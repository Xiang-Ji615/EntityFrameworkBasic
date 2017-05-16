using EntityFrameworkSqlServer.DataContext;
using EntityFrameworkSqlServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
            Console.WriteLine("TST");
            Console.ReadLine();
        }

        private async static void test()
        {
            using (var context = new UserContext())
            {
                //User user = new User() { Username = "JJ", Password = "Password" };
                //UserRole userRole = new UserRole() { Role = "ROLE_ADMIN" };
                //userRole.users = new List<User>();
                //userRole.users.Add(user);
                //user.userRole = userRole;
                //context.users.Add(user);
                //context.userRoles.RemoveRange(context.userRoles);
                await context.SaveChangesAsync();
                Console.WriteLine("Save Thread");
            }
        }
    }
}
