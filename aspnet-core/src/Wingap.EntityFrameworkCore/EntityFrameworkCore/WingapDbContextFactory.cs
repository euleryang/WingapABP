using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Wingap.Configuration;
using Wingap.Web;

namespace Wingap.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WingapDbContextFactory : IDesignTimeDbContextFactory<WingapDbContext>
    {
        public WingapDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WingapDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WingapDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WingapConsts.ConnectionStringName));

            return new WingapDbContext(builder.Options);
        }
    }
}
