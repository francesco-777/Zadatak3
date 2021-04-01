using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zadatak3.Models;
namespace Zadatak3.Controllers
{
    
    public class RacunController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Racun
        public ActionResult Index()
        {
            var racuni = _db.Racuni.ToList();
            return View(racuni);
        }

        // GET: Racun/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Racun racun = _db.Racuni.Find(id);
            if (racun == null)
            {
                return HttpNotFound();
            }
            return View(racun);
        }
        public ActionResult Create()
        {
            return View();
        }
        // POST: Racun/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(Racun racun)
        {
            if (ModelState.IsValid)
            {
                _db.Racuni.Add(racun);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(racun);
        }
        // GET: Racun/Edit/5
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Racun racun = _db.Racuni.Find(id);
            if (racun == null)
            {
                return HttpNotFound();
            }
            return View(racun); 
        }
        // POST: Racun/Edit/5 [HttpPost]
        public ActionResult Edit(Racun racun)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(racun).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(racun);
        }
        // GET: Racun/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Racun racun = _db.Racuni.Find(id);
            if (racun == null)
            {
                return HttpNotFound();
            }
            return View(racun);
        }
        // POST: Racun/Delete/5 
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Racun racun = _db.Racuni.Find(id);
            _db.Racuni.Remove(racun);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}