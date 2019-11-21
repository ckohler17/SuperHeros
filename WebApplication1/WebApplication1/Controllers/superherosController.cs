using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class superherosController : Controller
    {
        ApplicationDbContext context;
        public superherosController()
        {
            context = new ApplicationDbContext();
        }
        // GET: superheros
        public ActionResult Index()
        {
            return View();
        }

        // GET: superheros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: superheros/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: superheros/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            
            try
            {
                // TODO: Add insert logic here
                context.Superhero.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: superheros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: superheros/Edit/5
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

        // GET: superheros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: superheros/Delete/5
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
