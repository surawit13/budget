using System.Collections.Specialized;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetcore.Dbcon;
using dotnetcore.Models;
namespace dotnetcore.Controllers
{
    // [Route("[controller]")]
    public class UserController : Controller
    {
        // private readonly ILogger<UserController> _logger;
        private readonly Dbconnect _Dbcon;
        // private MovieDBContext db = new MovieDBContext();

        // public UserController(ILogger<UserController> logger,Dbcon Dbcon)
        // {
        //     _logger = logger;
        //     _Dbcon = Dbcon;
        // }
          public UserController(Dbconnect Dbcon)
        {
            // _logger = logger;
            _Dbcon = Dbcon;
        }

        public IActionResult Index()
        {
            var data = _Dbcon.User.ToList();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}