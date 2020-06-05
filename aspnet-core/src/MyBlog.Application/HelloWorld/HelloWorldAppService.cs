using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace MyBlog.HelloWorld
{
    public class HelloWorldAppService : ApplicationService, IHelloWorldAppService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
