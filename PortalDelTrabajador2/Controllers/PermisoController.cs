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
    public class PermisoController : Controller
    {
        private PermisoDBContext db = new PermisoDBContext();

        //
        // GET: /Permiso/

        public ActionResult Index()
        {
            return View(db.Permisos.ToList());
        }

        //
        // GET: /Permiso/Details/5

        public ActionResult Details(int id = 0)
        {
            Permiso permiso = db.Permisos.Find(id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }

        //
        // GET: /Permiso/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Permiso/Create

        [HttpPost]
        public ActionResult Create(Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                db.Permisos.Add(permiso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(permiso);
        }

        //
        // GET: /Permiso/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Permiso permiso = db.Permisos.Find(id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }

        //
        // POST: /Permiso/Edit/5

        [HttpPost]
        public ActionResult Edit(Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permiso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(permiso);
        }

        //
        // GET: /Permiso/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Permiso permiso = db.Permisos.Find(id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }

        //
        // POST: /Permiso/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Permiso permiso = db.Permisos.Find(id);
            db.Permisos.Remove(permiso);
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