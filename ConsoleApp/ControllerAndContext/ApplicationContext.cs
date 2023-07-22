using Microsoft.EntityFrameworkCore;
using LearningCS.Models;

namespace LearningCS.ApplicationContext;
class MyContext : DbContext {
    public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
    public DbSet<Books> Books {get; set;}
}