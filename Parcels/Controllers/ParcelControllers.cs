using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels/new")]
    public ActionResult ParcelForm()
    {
      return View();
    }

    [HttpPost("/parcelinfo")]
    public ActionResult ParcelInfo(int length, int width, int height, int weight)
    {
      if (ModelState.IsValid)
      {
        Parcel newParcel = new Parcel(length, width, height, weight);
        return View(newParcel);
      }
      else
      {
        string error = "Please fill out all fields.";
        return View(error);
      }
    }

    [HttpGet("/index")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
  }
}