using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Structure_Helper.Models;

namespace Structure_Helper.Controllers
{
    public class StructuresController : Controller
    {
        private StructureDBContext db = new StructureDBContext();

        // GET: Structures
        public ActionResult Index()
        {
            return View(db.Structures.ToList());
        }

        // GET: Structures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Structure_Helper.Models.Structure structure = db.Structures.Find(id);
            if (structure == null)
            {
                return HttpNotFound();
            }
            return View(structure);
        }

        // GET: Structures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Structures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Job,Shot,Label,Elevation,Northing,Easting,Type,X,Y")] Structure_Helper.Models.Structure structure)
        {
            if (ModelState.IsValid)
            {
                db.Structures.Add(structure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(structure);
        }

        // GET: Structures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Structure_Helper.Models.Structure structure = db.Structures.Find(id);
            if (structure == null)
            {
                return HttpNotFound();
            }
            return View(structure);
        }

        // POST: Structures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Job,Shot,Label,Elevation,Northing,Easting,Type,X,Y")] Structure structure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(structure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(structure);
        }

        // GET: Structures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Structure_Helper.Models.Structure structure = db.Structures.Find(id);
            if (structure == null)
            {
                return HttpNotFound();
            }
            return View(structure);
        }

        // POST: Structures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Structure_Helper.Models.Structure structure = db.Structures.Find(id);
            db.Structures.Remove(structure);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
