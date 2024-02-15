using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHouse.Controllers
{
    public class HoueseController : Controller
    {
        // GET: HoueseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HoueseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HoueseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HoueseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HoueseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HoueseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HoueseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HoueseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
