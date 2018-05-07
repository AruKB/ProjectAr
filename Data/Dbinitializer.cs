using System;
using System.Linq;
using project.Models;
using project.EmpDataContext;
namespace project.Data
{
    public static class Dbinitializer
    {
            public static void Initialize(AppDataContext context)
            {
                context.Database.EnsureCreated();
                if(context.StatusUsers.Any())
                {
                    return;
                }
                var status_Users = new StatusUsers[]
                {
                    new StatusUsers{Status = "Admin"},
                    new StatusUsers{Status = "User"}
                };
                foreach(StatusUsers u_s in status_Users)
                {
                    context.StatusUsers.Add(u_s);
                }
                context.SaveChanges();

                var blog_Status = new BlogsStatus[]
                {
                    new  BlogsStatus{Status="Accept"},
                    new BlogsStatus{Status="Decline"},
                    new BlogsStatus{Status="Waiting"}
                };

                foreach(BlogsStatus b_s in blog_Status)
                {
                    context.BlogsStatus.Add(b_s);
                }
                context.SaveChanges();

                if(context.Users.Any())
                {
                    return;
                }

                var users = new Users{Users_Name="Aruzhan", Users_Logins="aru", Users_Password="nopromises998", Users_Id=1};
                context.Users.Add(users);
                context.SaveChanges();
                
            }
        }
    }
