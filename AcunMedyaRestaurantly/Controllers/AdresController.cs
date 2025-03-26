using AcunMedyaRestaurantly.Context;
using AcunMedyaRestaurantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaRestaurantly.Controllers
{
    [Authorize]
    public class AdresController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Adres

        public ActionResult Index()
        {
            var value = Db.Adreses.ToList();
            return View(value);
        }
        public ActionResult AdresList()
        {
            var value = Db.Adreses.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AdresCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdresCreate(Adres model)
        {
            Db.Adreses.Add(model);
            Db.SaveChanges();
            return RedirectToAction("AdresList");
        }
        [HttpGet]
        public ActionResult AdresEdit(int id)
        {
            var value = Db.Adreses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult AdresEdit(Adres model)
        {
            var values = Db.Adreses.Find(model.AdresId);
            values.Location = model.Location;
            values.OpenHours = model.OpenHours;
            values.Email = model.Email;
            values.Call = model.Call;
            Db.SaveChanges();
            return RedirectToAction("AdresList");
        }
        public ActionResult AdresDelete(int id)
        {
            var values = Db.Adreses.Find(id);
            Db.Adreses.Remove(values);
            Db.SaveChanges();
            return RedirectToAction("AdresList");
        }
    }
}