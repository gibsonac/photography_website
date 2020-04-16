using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Photography_Website.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Photography_Website.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.Users.ToList();
            ViewBag.location = "home";
            return View();
        }
        [HttpGet]
        [Route("underwater")]
        public IActionResult Underwater()
        {
            List<Image> allImages = dbContext.Images
            .Where(I => I.category == 1)
            .ToList();
            ViewBag.Images = allImages;
            return View();
        }
        [HttpGet]
        [Route("landscape")]
        public IActionResult Landscape()
        {
            List<Image> allImages = dbContext.Images
            .Where(I => I.category == 2)
            .ToList();
            ViewBag.Images = allImages;
            return View();
        }
        [HttpGet]
        [Route("portrait")]
        public IActionResult Portrait()
        {
            List<Image> allImages = dbContext.Images
            .Where(I => I.category == 3)
            .ToList();
            ViewBag.Images = allImages;
            return View();
        }
        [HttpGet]
        [Route("image/{id}")]
        public IActionResult Image(int id)
        {
            Image theImage = dbContext.Images.FirstOrDefault(Image => Image.id == id);
            ViewBag.Image = theImage;
            return View();
        }
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        [Route("gallery")]
        public IActionResult Gallery()
        {
            // getting 3 underwater images
            List<Image> ThreeUnderwater = dbContext.Images
            .Where(I => I.category == 1)
            .ToList();
            ViewBag.UnderwaterImages = ThreeUnderwater;
            //getting 3 landscape images
            List<Image> ThreeLandscape = dbContext.Images
            .Where(I => I.category == 2)
            .ToList();
            ViewBag.LandscapeImages = ThreeLandscape;
            // getting 3 portrait images
            List<Image> ThreePortrait = dbContext.Images
            .Where(I => I.category == 3)
            .ToList();
            ViewBag.PortraitImages = ThreePortrait;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
