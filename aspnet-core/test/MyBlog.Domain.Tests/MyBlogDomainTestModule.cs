using MyBlog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyBlog
{
    [DependsOn(
        typeof(MyBlogEntityFrameworkCoreTestModule)
        )]
    public class MyBlogDomainTestModule : AbpModule
    {

    }
}