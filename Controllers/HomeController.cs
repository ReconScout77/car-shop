using Microsoft.AspNetCore.Mvc;
using CarShop.Models;
using System.Collections.Generic;

namespace CarShop.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/car/list")]
    public ActionResult CarListList()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/car/create")]
      public ActionResult CarList()
      {
        Car newCar = new Car (Request.Form["new-model"], int.Parse(Request.Form["new-price"]), int.Parse(Request.Form["new-miles"]));
        newCar.Save();
        return View(newCar);
      }

      [HttpPost("car/list/clear")]
      public ActionResult CarListClear()
      {
        Car.ClearAll();
        return View();
      }
  }
}
