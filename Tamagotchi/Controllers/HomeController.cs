using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Title() { return View(); }

  }
}