using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay6.Controllers;

[Route("/user")]
public class UserController : Controller
{
    //Method
    [HttpGet]
    [Route("add")]
    public IActionResult RenderAddUserForm()
    {
        return View("Add");//this is the template name Add.cshtml
    }

[HttpPost("/user")]
    public IActionResult SubmitAddUserForm(User newUser, string verify) {
      // add form submission handling code here
        ViewBag.User = newUser;
        if(newUser.Password == verify)
        {
            // ViewBag.Username = newUser.Username;
            return View("Index");
        }
        else
        {
            ViewBag.Error = "Password does not match.";
            return View("Add");
        }
   }
}
