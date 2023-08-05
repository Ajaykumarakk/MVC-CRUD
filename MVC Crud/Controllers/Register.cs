using CRUD.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegLibrary.Model;
using System.Collections.Generic;

namespace MVC_Crud.Controllers
{
    public class Register : Controller
    {
        RegCrud obj;
        public Register()
        {
            obj = new RegCrud();
        }
        // GET: Register
        public ActionResult List()
        {
            return View("List",new List<RegModel>(obj.Select()));
        }

        // GET: Register/Details/5
        public ActionResult Details(int Id)
        {
            var res = obj.Select(Id);
            return View("Details",res);
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View("Create",new RegModel());
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegModel reg)
        {
            try
            {
                obj.Insert(reg);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int Id)
        {
            var res = obj.Select(Id);
            return View("Edit",res);
        }

        // POST: Register/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, RegModel reg)
        {
            try
            {
                reg.Id = id;
                obj.Update(reg);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int Id)
        {
            var res = obj.Select(Id);
            return View("Delete", res);
        }

        // POST: Register/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int Id)
        {
            try
            {
                obj.Delete(Id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
