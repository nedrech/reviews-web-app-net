using Microsoft.AspNetCore.Mvc;

namespace Nedrech.ReviewsWebApp.Controllers;

public class HomeController : Controller
{
    public ViewResult Index() =>
        View();
}