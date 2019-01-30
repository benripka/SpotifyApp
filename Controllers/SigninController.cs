using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpotifyApp.Models;

namespace SpotifyApp.Controllers
{
    public class SigninController : Controller
    {

        private Spotify spotify = new Spotify();

        public SigninController()
        {
            spotify.Setup();
        }
        public IActionResult Index()
        {
            return View(spotify);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
