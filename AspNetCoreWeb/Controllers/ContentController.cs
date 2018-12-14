using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreWeb.Models;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreWeb.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptionsSnapshot<Content> option)
        {
            contents = option.Value;
        } 

        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var builder=new ConfigurationBuilder().AddJsonFile("Content.json");
            var Configuration = builder.Build();
            var content = Configuration["ContentList:add_time"];
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            //return View(new ContentViewModel { Contents = contents });

            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}
