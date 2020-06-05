using MyBlog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MyBlogController : AbpController
    {
        protected MyBlogController()
        {
            LocalizationResource = typeof(MyBlogResource);
        }
    }
}