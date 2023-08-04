using CRUD.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegLibrary.Model;
using System.Collections.Generic;


namespace MVC_Reg.Controllers
{
    public class RegisterController : Controller
    {
        RegCrud obj;
        public RegisterController()
        {
            obj = new RegCrud();
        }
        // GET: RegisterController
        public ActionResult List()
        {
            return View("RegList",new List<RegModel>(obj.Select()) );
        }

        // GET: RegisterController/Details/5
        public ActionResult Details(int Id)
        {
            var res = obj.Select(Id);
            return View();
        }

        // GET: RegisterController/Create
        public ActionResult Create()
        {
            return View("Create",new RegModel());
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegModel Reg)
        {
            try
            {
                obj.Insert(Reg);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Edit/5
        public ActionResult Edit(int Id)
        {
            var res =obj.Select(Id);
            return View("Edit",res);
        }

        // POST: RegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,RegModel Reg)
        {
            try
            {
                Reg.Id = id;
                obj.Update(Reg);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Delete/5
        public ActionResult Delete(int Id)
        {
            var res = obj.Select(Id);
            return View("Delete", res);
        }

        // POST: RegisterController/Delete/5
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
