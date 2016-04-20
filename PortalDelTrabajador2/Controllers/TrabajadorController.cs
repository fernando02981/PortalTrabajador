using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalDelTrabajador2.Models;

namespace PortalDelTrabajador2.Controllers
{
    public class TrabajadorController : Controller
    {
        private TrabajadorDBContext db = new TrabajadorDBContext();

        //
        // GET: /Trabajador/

        public ActionResult Index()
        {
            return View(db.Trabajadores.ToList());
        }

        //
        // GET: /Trabajador/Details/5

        public ActionResult Details(int id = 0)
        {
            Trabajador trabajador = db.Trabajadores.Find(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        //
        // GET: /Trabajador/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Trabajador/Create

        [HttpPost]
        public ActionResult Create(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                db.Trabajadores.Add(trabajador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trabajador);
        }

        //
        // GET: /Trabajador/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Trabajador trabajador = db.Trabajadores.Find(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        //
        // POST: /Trabajador/Edit/5

        [HttpPost]
        public ActionResult Edit(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trabajador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabajador);
        }

        //
        // GET: /Trabajador/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Trabajador trabajador = db.Trabajadores.Find(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        //
        // POST: /Trabajador/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Trabajador trabajador = db.Trabajadores.Find(id);
            db.Trabajadores.Remove(trabajador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}