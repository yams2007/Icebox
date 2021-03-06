﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Icebox.Models;

namespace Icebox.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            var model = new PostViewModel
            {
                PostContent = new ImageContent("http://images5.fanpop.com/image/photos/31300000/Changmin-Wallpaper-max-changmin-31380483-1600-1000.jpg"),
                Tags = new List<string>()
                {
                    "Fridge man",
                    "Smile",
                    "Background"
                }
            };
            return View(model);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
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

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
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

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Posts/Delete/5
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
