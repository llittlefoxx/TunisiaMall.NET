using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisaMall.data.Models;
using TunisiaMall.service;

namespace TunisiaMall.Controllers
{
    public class PromotionController : Controller
    {
        PromotionService promServ;
        public PromotionController(PromotionService promServ)
        {
            this.promServ = promServ;
        }
        // GET: Promotion
        public ActionResult Index()
        {
            var l = promServ.GetAllPromo();
            return View(l);
        }

        // GET: Promotion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Promotion/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Promotion/Create
        [HttpPost]
        public ActionResult Create(promotion promo)
        {
          
                promServ.AddPromotion(promo);
                return RedirectToAction("Index");
        
        }

        // GET: Promotion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Promotion/Edit/5
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

        // GET: Promotion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Promotion/Delete/5
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
