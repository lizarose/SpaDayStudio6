using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/add")]
        public IActionResult Add()
        {
            //Passing an instance of AddUserViewModel to User/Add.cshtml via Add() action method
            AddUserViewModel addUserViewModel = new();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            //ModelState.IsValid is checking the conditions outlined using the validation attributes and if valid will return the page back to Index
            if (ModelState.IsValid)
            {
                //This checks the passwords are matching and if they are then creates a new user and adds their username, password, and email, and sends them to the Index page
                if(addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new()
                    {
                        Username = addUserViewModel.Username,
                        Password = addUserViewModel.Password,
                        Email = addUserViewModel.Email
                    };
                    return View("Index", newUser);
                }
                else
                {
                    //If the user's password does not match then it sends the user back to the Add.cshtml page
                    ViewBag.error = "Passwords do not match.";
                    return View("Add", addUserViewModel);
                }
                
            }
            else
            {
                //If the conditions are not valid it will return back to Add.cshtml page
                return View("Add", addUserViewModel);
            }
        }
    }
}

