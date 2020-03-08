using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MpgMvc.DAL;
using MpgMvc.Models;

namespace MpgMvc.Controllers
{
    public class MileageController : Controller
    {
        private MpgContext db = new MpgContext();

        // GET: Mileage
        public ActionResult Index()
        {
            var mileages = db.Mileages.Include(m => m.User).Include(m => m.Vehicle);
            return View(mileages.ToList());
        }

        // GET: Mileage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mileage mileage = db.Mileages.Find(id);
            if (mileage == null)
            {
                return HttpNotFound();
            }
            return View(mileage);
        }

        // GET: Mileage/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Username");
            ViewBag.VehicleID = new SelectList(db.Vehicles, "ID", "Make");
            return View();
        }

        // POST: Mileage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,Miles,Gallons,PriceGallon,VehicleID,UserID,Comment,CreateDt,LastUpdateDt")] Mileage mileage)
        {
            if (ModelState.IsValid)
            {
                db.Mileages.Add(mileage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "ID", "Username", mileage.UserID);
            ViewBag.VehicleID = new SelectList(db.Vehicles, "ID", "Make", mileage.VehicleID);
            return View(mileage);
        }

        // GET: Mileage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mileage mileage = db.Mileages.Find(id);
            if (mileage == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Username", mileage.UserID);
            ViewBag.VehicleID = new SelectList(db.Vehicles, "ID", "Make", mileage.VehicleID);
            return View(mileage);
        }

        // POST: Mileage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,Miles,Gallons,PriceGallon,VehicleID,UserID,Comment,CreateDt,LastUpdateDt")] Mileage mileage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mileage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Username", mileage.UserID);
            ViewBag.VehicleID = new SelectList(db.Vehicles, "ID", "Make", mileage.VehicleID);
            return View(mileage);
        }

        // GET: Mileage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mileage mileage = db.Mileages.Find(id);
            if (mileage == null)
            {
                return HttpNotFound();
            }
            return View(mileage);
        }

        // POST: Mileage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mileage mileage = db.Mileages.Find(id);
            db.Mileages.Remove(mileage);
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
