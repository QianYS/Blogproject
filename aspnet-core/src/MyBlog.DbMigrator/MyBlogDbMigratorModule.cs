using MyBlog.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MyBlog.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MyBlogEntityFrameworkCoreDbMigrationsModule),
        typeof(MyBlogApplicationContractsModule)
        )]
    public class MyBlogDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
