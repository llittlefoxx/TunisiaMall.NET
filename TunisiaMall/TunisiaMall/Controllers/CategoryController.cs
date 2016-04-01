using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisaMall.data.Models;
using TunisiaMall.service;

namespace TunisiaMall.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService catse;
        public CategoryController(CategoryService catse)
        {
         this.catse = catse;
        }
        // GET: Category
        public ActionResult Index()
        {
            var l = catse.getAllCategorys();
            return View(l);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(category cat)
        {

                catse.AddCategory(cat);
            System.Diagnostics.Debug.WriteLine("This will be displayed in output window");
            return RedirectToAction("Index");
 

        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
