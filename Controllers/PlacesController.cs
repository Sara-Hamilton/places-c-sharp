using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
            Place newPlace = new Place(Request.Form["new-city"], Request.Form["new-state"]);
            newPlace.Save();
            List<Place> allPlaces = Place.GetAll();
            return View("Index", allPlaces);
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View("Index");
        }

    }
}
