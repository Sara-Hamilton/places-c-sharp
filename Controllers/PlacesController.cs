using Microsoft.AspNetCore.Mvc;
using Places.Models;

namespace Places.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            Place newPlace = new Place(Request.Query["new-city"], Request.Query["new-state"]);
            return View(newPlace);
        }

        [HttpGet("/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

    }
}
