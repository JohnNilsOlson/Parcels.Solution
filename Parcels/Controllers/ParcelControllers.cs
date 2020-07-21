using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

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
      Parcel newParcel = new Parcel(length, width, height, weight);
      return View(newParcel);
    }

    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View();
    }
  }
}