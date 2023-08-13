using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CamelSystem.Authorization.Roles;
using CamelSystem.Authorization.Users;
using CamelSystem.MultiTenancy;
using CamelSystem.Lookups;

namespace CamelSystem.EntityFrameworkCore
{
    public class CamelSystemDbContext : AbpZeroDbContext<Tenant, Role, User, CamelSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Camel> Camels { get; set; }
        public DbSet<MechanicalMeasurement> MechanicalMeasurements { get; set; }
        public DbSet<AnthropometricMeasurement> AnthropometricMeasurements { get; set; }
        public DbSet<CausalVariable> CausalVariables { get; set; }

        public CamelSystemDbContext(DbContextOptions<CamelSystemDbContext> options)
            : base(options)
        {
        }
    }
}
