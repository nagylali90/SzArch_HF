﻿using Bll;
using Bll.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PublicEventsController : Controller
    {
        // GET: PublicEvents
        public ActionResult Index()
        {
            //var model = new Bll.EventManager().GetAllEvent();
            return View(new Bll.EventManager().GetAllEvent());
        }

        // GET: PublicEvents/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PublicEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicEvents/Create
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

        // GET: PublicEvents/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PublicEvents/Edit/5
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

        // GET: PublicEvents/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PublicEvents/Delete/5
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
