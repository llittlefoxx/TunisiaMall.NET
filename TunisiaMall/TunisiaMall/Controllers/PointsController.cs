﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TunisiaMall.Controllers
{
    public class PointsController : Controller
    {
        // GET: Points
        public ActionResult Index()
        {
            return View();
        }

        // GET: Points/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Points/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Points/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Points/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Points/Edit/5
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

        // GET: Points/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Points/Delete/5
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
