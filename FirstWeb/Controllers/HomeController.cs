using Microsoft.AspNetCore.Mvc; //this allows us to use micsofts mvc features
namespace FirstWeb.Controllers;// this isthe namespace which tells us what they are inside of, flag that says this is a cotroller file

public class HomeController : Controller //inherits from controller
{
    [HttpGet("")]
    public ViewResult Index()
    {

        return View("Index");
    }

    [HttpGet("/videos")]
    public ViewResult Videos()
    {
        return View("Videos");
    }
}