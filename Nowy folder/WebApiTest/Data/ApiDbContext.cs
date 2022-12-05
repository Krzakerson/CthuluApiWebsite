using Microsoft.EntityFrameworkCore;
using WebApiTest.Models;

namespace WebApiTest.Data
{
    public class ApiDbContext:DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<GreatOldOne> greatOldOnes { get; set; }
        public DbSet<GreatOne> greatOnes { get; set; }
        public DbSet<OuterGod> outerOnes { get; set; }

        public DbSet<Story> stories { get; set; }   


    }
}
