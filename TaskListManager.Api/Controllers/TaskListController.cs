using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskListManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskListController : ControllerBase
    {
        // GET: TaskListController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TaskListController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TaskListController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskListController/Create
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

        // GET: TaskListController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskListController/Edit/5
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

        // GET: TaskListController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TaskListController/Delete/5
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
