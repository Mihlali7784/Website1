using DragonBallZ.Data;
using DragonBallZ.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBallZ.Controllers
{
   // [Authorize(Roles = "Admin")]
    public class CharactorController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public CharactorController(ApplicationDbContext dBD)
        {
            dbContext = dBD;
        }
        public IActionResult Index()
        {
            IEnumerable<ZFighters> objList = dbContext.ZFighters;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult Create(ZFighters games)
        {
            if (ModelState.IsValid)
            {
                dbContext.ZFighters.Add(games);
                dbContext.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(games);


        }
        public IActionResult Update(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.ZFighters.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ZFighters games)
        {
            dbContext.ZFighters.Update(games);
            dbContext.SaveChanges();
            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? ID)
        {
            var obj = dbContext.ZFighters.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            dbContext.ZFighters.Remove(obj);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult uPDATEeii(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            var obj = dbContext.ZFighters.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

              
        }
        public IActionResult uPDATEeii(ZFighters okay)
        {
            dbContext.ZFighters.Update(okay);
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
