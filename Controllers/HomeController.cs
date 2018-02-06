
using Microsoft.AspNetCore.Mvc;
using ShippingCalculator.Models;

namespace ShippingCalculator.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
          return View();
        }
        [Route("/parcel")]
        public ActionResult Parcel()
        {
          Parcel userParcel = new Parcel();
          userParcel.SetHeight(Request.Query["height"]);
          userParcel.SetWeight(Request.Query["weight"]);
          userParcel.SetLength(Request.Query["length"]);
          userParcel.SetWidth(Request.Query["width"]);
          return View(userParcel);
        }
    }
}
