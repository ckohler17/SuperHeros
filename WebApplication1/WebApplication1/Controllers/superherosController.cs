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
            var index = context.Superhero.ToList();
            return View(index);
        }

        // GET: superheros/Details/5
        public ActionResult Details(int id)
        
        {
            Superhero superhero = context.Superhero.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
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
            Superhero superhero = context.Superhero.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: superheros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero superherofromdb = context.Superhero.Where(s => s.Id == id).FirstOrDefault();
                superherofromdb.name = superhero.name;
                superherofromdb.alterEgo = superhero.alterEgo;
                superherofromdb.primaryAbility = superhero.primaryAbility;
                superherofromdb.secondaryAbility = superhero.secondaryAbility;
                superherofromdb.catchphrase = superhero.catchphrase;
                context.SaveChanges();
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
            Superhero superhero = context.Superhero.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: superheros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                superhero = context.Superhero.Where(s => s.Id == id).FirstOrDefault();
                context.Superhero.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
