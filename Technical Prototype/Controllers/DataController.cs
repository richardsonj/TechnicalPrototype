using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Technical_Prototype.Models;

namespace Technical_Prototype.Controllers
{
    public class DataController : Controller
    {
        private DataDBContext db = new DataDBContext();

        // GET: /Data/
        public ActionResult Index()
        {
            return View(db.Data.ToList());
        }

        // GET: /Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataModel datamodel = db.Data.Find(id);
            if (datamodel == null)
            {
                return HttpNotFound();
            }
            return View(datamodel);
        }

        // GET: /Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,X,Y")] DataModel datamodel)
        {
            if (ModelState.IsValid)
            {
                db.Data.Add(datamodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datamodel);
        }

        // GET: /Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataModel datamodel = db.Data.Find(id);
            if (datamodel == null)
            {
                return HttpNotFound();
            }
            return View(datamodel);
        }

        // POST: /Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,X,Y")] DataModel datamodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datamodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datamodel);
        }

        // GET: /Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataModel datamodel = db.Data.Find(id);
            if (datamodel == null)
            {
                return HttpNotFound();
            }
            return View(datamodel);
        }

        // POST: /Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataModel datamodel = db.Data.Find(id);
            db.Data.Remove(datamodel);
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
