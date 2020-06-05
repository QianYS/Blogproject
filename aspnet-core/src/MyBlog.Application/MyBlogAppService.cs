using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Localization;
using Volo.Abp.Application.Services;

namespace MyBlog
{
    /* Inherit your application services from this class.
     */
    public abstract class MyBlogAppService : ApplicationService
    {
        protected MyBlogAppService()
        {
            LocalizationResource = typeof(MyBlogResource);
        }
    }
}
