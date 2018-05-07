using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.EmpDataContext
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options):base(options)
        {
            
        }
        public DbSet<Users> Users{get;set;}
        public DbSet<StatusUsers> StatusUsers{get;set;}
        public DbSet<BlogsStatus> BlogsStatus{get;set;}
        public DbSet<BLOGS> BLOGS{get;set;}

    }
}