using Microsoft.AspNetCore.Mvc;
using TamagotchiGame.Models;

namespace TamagotchiGame.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Title() { return View(); }

  }
}