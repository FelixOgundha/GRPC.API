using GRPC_Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace GRPC_Sample.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
