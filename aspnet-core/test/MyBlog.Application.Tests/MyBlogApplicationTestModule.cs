using Volo.Abp.Modularity;

namespace MyBlog
{
    [DependsOn(
        typeof(MyBlogApplicationModule),
        typeof(MyBlogDomainTestModule)
        )]
    public class MyBlogApplicationTestModule : AbpModule
    {

    }
}