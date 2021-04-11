using LayerBlog.Business.Abstracts;
using LayerBlog.Models.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayerBlog.UI.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        public IActionResult Index()
        {
            return View( );
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View(new PostDTO());
        }

        
    }
}
