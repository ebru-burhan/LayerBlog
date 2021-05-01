using LayerBlog.Business.Abstracts;
using LayerBlog.Models.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayerBlog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        public HomeController(IPostService postService, IUserService userService)
        {
            _postService = postService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            // return View(_postService.GetPosts());

            UserDTO userDto = new UserDTO()
            {
                FirstName = "ebru",
                Lastname = "burhan",
                Email = "asd@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Entities.Enums.Gender.Female,
                Password = "123",
                UserName = "sylthoria"
            };
            _userService.AddUser(userDto);

            var userList = _userService.GetUsers();
            var updatelenecek = userList.FirstOrDefault();
            updatelenecek.Email = "aaaaaaaaa@gmail.com";
            _userService.UpdateUser(updatelenecek);

            userList = _userService.GetUsers();
            var deletelenecek = userList.FirstOrDefault();
            _userService.DeleteUser(deletelenecek.UserID);
            userList = _userService.GetUsers();

            return View();
        }
    }
}
