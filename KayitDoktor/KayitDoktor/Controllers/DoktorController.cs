using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KayitDoktor.Models;

namespace KayitDoktor.Controllers
{
    public class DoktorController : Controller
    {
        // GET: Doktor
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult DoktorEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoktorEkle(DoktorDb Veri)
        {
            Db.DoktorDb.Add(Veri);
            Db.SaveChanges();
            return View();
        }
    }
}