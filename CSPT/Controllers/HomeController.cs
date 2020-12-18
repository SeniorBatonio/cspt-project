using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSPT.Models;
using CSPT.Interfaces;

namespace CSPT.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IAboutService aboutService;
        private readonly ILogger<HomeController> logger;

        public HomeController(
            IPostsService postsService,
            IAboutService aboutService,
            ILogger<HomeController> logger)
        {
            this.postsService = postsService;
            this.aboutService = aboutService;
            this.logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            try
            {
                var about = await aboutService.GetAboutInfoAsync();
                var posts = await postsService.GetPostsAsync();

                return View(new LandingViewModel
                {
                    AboutMe = about.Take(2).Select(s => s.Content),
                    Posts = posts.Take(3)
                });
            }
            catch(Exception e)
            {
                logger.LogError(e.Message, e);
                return StatusCode(500, e);
            }
        }
    }
}
