using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SimpleLoginRegistration.Models;

namespace SimpleLoginRegistration.Controllers
{

public class LoginAndRegistrationController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpPost("register")]
    public IActionResult Register(UserRegistration userRegistration)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        return RedirectToAction("Success");
    }

    [HttpPost("login")]
    public IActionResult Login(UserLogin userLogin)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        return RedirectToAction("Success");
    }

    [HttpGet("success")]
    public ViewResult Success()
    {
        return View("Success");
    }
}

}