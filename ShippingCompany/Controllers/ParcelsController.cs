using Microsoft.AspNetCore.Mvc;
using ShippingCompany.Models;
using System.Collections.Generic;

namespace ShippingCompany.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {

      return View();
      // is a list neccessary because the data won't be stored anywhere without it???
      // alternatively, can we transfer inputted form data without storing an instance of parcel?
      // YES YOU NEED A LIST! IT FUNCTIONS AS A ERSATZ DATABASE, THAT IS HOW THE INSTANCES ARE STORED AND TRANSPORTED FROM FUNCTION TO FUNCTION.
    }

    [HttpGet("/parcels/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/new")]
    public ActionResult Create(double height, double width, double depth)
    {
      Parcel newParcel = new Parcel(height, width, depth);
      return RedirectToAction("Index");
    }

  }
}