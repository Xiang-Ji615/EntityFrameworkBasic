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
            User ret;
            using (var context = new UserContext())
            {
                //var test = context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                //User user = new User() { Username = "JJ", Password = "Password" };
                //UserRole userRole = new UserRole() { Role = "ROLE_ADMIN" };
                //userRole.users = new List<User>();
                //userRole.users.Add(user);
                //user.userRole = userRole;
                //context.users.Add(user);
                ////context.userRoles.RemoveRange(context.userRoles);
                //var users = context.users.Where(a => a.Username == "JJ").ToList();
                //ret = context.users.Include("UserRole").Where(a => a.Username.StartsWith("J")).FirstOrDefault();
                //await context.SaveChangesAsync();
                //Console.WriteLine("Save Thread");
                //test.Commit();
                var user = getUser();
                user.Wait();
                User userResult = user.Result;
                //Console.ReadLine();
                Console.WriteLine(userResult.Password);
            }

        }

        private static async Task<User> getUser()
        {
            User user;

            using(var context = new UserContext())
            {
                Console.WriteLine("Start GetStudent...");

                user = await context.users.FindAsync(8);
                Console.WriteLine(user);
                Console.WriteLine("Finished GetStudent...");
            }
            return user;
        }
    }
}
