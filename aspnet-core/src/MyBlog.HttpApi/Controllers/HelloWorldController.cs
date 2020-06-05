using Microsoft.AspNetCore.Mvc;
using MyBlog.HelloWorld;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : AbpController
    {
        private readonly IHelloWorldAppService _helloWorldService;

        public HelloWorldController(IHelloWorldAppService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        public string HelloWorld()
        {
            //return "zhijie fanhui";
            return _helloWorldService.HelloWorld();
        }
    }
}
