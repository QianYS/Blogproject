using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MyBlog.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MyBlogHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MyBlogConsoleApiClientModule : AbpModule
    {
        
    }
}
