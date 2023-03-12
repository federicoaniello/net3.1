using Microsoft.EntityFrameworkCore;
using net3._1.Models;

namespace net3._1.Data
{
    public class Net3_1Context : DbContext
    {
        public Net3_1Context(DbContextOptions<Net3_1Context> options)
            : base(options)
        {
        }

        public DbSet<CarouselFirst> carouselFirsts;
        public DbSet<Brand> brands;
        public DbSet<Product> products;
        public DbSet<ShowCase> showCases;
    }
}
