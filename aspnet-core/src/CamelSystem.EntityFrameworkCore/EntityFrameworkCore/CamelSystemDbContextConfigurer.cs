using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CamelSystem.EntityFrameworkCore
{
    public static class CamelSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CamelSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CamelSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
