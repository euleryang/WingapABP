using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Wingap.EntityFrameworkCore
{
    public static class WingapDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WingapDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WingapDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
