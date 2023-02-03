using Microsoft.EntityFrameworkCore;

namespace net3._1.Data
{
    public class net3_1Context : DbContext
    {
        public net3_1Context(DbContextOptions<net3_1Context> options)
            : base(options)
        {
        }

    }
}
