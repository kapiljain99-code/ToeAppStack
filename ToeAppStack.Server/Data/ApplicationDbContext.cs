using Microsoft.EntityFrameworkCore;

namespace ToeAppStack.Server.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
