using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Pierres.Models;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;

    public HomeController(PierresContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Flavor = new List<Flavor>(_db.Flavors);
      return View(_db.Treats.ToList());
    }
  }
}