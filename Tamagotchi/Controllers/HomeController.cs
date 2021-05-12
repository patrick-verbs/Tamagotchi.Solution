using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index() { return View(); }
    // {
    //   List<Pet> allPets = Pet.GetAll();
    //   return View(allPets);
    // }
    [HttpPost("/game")]
    {
      public ActionResult Index() { return View(); }

      public ActionResult Create(string name, string food, int attention, int time)
      {
        Pet TamagotchiInfo = new(
          name,
          food,
          Convert.ToInt32(attention),
          Convert.ToInt32(time)
        );
        return View(TamagotchiInfo);     
      }
    }
  }
}
