using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Wingap.Authorization.Roles;
using Wingap.Authorization.Users;
using Wingap.MultiTenancy;

namespace Wingap.EntityFrameworkCore
{
    public class WingapDbContext : AbpZeroDbContext<Tenant, Role, User, WingapDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WingapDbContext(DbContextOptions<WingapDbContext> options)
            : base(options)
        {
        }
    }
}
