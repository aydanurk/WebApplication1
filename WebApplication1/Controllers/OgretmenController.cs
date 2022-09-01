using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OgretmenController : Controller
    {

        private readonly AppDBContext _db;
        public OgretmenController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Ogretmen> objOgretmenList = _db.Ogretmenler;
            return View(objOgretmenList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ogretmen obj)
        {
            if (ModelState.IsValid)
            {
                _db.Ogretmenler.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var ogretmenFromDb = _db.Ogretmenler.Find(id);
            if (ogretmenFromDb == null)
            {
                return NotFound();
            }
            return View(ogretmenFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Ogretmen obj)
        {
            if (ModelState.IsValid)
            {
                _db.Ogretmenler.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var ogretmenFromDb = _db.Ogretmenler.Find(id);
            if (ogretmenFromDb == null)
            {
                return NotFound();
            }
            return View(ogretmenFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Ogretmenler.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Ogretmenler.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
