using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyBlog.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MyBlogMigrationsDbContextFactory : IDesignTimeDbContextFactory<MyBlogMigrationsDbContext>
    {
        public MyBlogMigrationsDbContext CreateDbContext(string[] args)
        {
            MyBlogEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MyBlogMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MyBlogMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
