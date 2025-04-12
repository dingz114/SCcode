using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace OrderApi.Data
{
    public class OrderContextFactory : IDesignTimeDbContextFactory<OrderContext>
    {
        public OrderContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;database=OrderDB;user=root;password=865486", 
                new MySqlServerVersion(new Version(8, 0, 37))
            );

            return new OrderContext(optionsBuilder.Options);
        }
    }
}