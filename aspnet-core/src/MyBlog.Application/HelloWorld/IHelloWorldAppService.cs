using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace MyBlog.HelloWorld
{
    public interface IHelloWorldAppService : IApplicationService
    {
        string HelloWorld();
    }
}
