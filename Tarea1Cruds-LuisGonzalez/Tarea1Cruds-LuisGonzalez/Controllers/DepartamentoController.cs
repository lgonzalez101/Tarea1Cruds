using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea1Cruds_LuisGonzalez.DB;
using Tarea1Cruds_LuisGonzalez.Models;

namespace Tarea1Cruds_LuisGonzalez.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {

            using (var context = new TareaEntities())
            {
                var list = context.Departamento.Select(x=>new DepartamentoViewModel { Id = x.Id, NombreDepartamento=x.NombreDepartamento}).ToList();
                return View(list);
            }
                
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new DepartamentoViewModel());
        }

        [HttpPost]
        public ActionResult Create(DepartamentoViewModel model)
        {
            using (var context = new TareaEntities())
            {
                context.Departamento.Add(new Departamento {NombreDepartamento=model.NombreDepartamento });
                if (context.SaveChanges()>0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Error al guardar");
                    return View(model);
                }
               
            }
        }


        [HttpGet]
        public ActionResult Edit(int Id)
        {
            using (var context = new TareaEntities())
            {
                var model = context.Departamento.Find(Id);
                return View(new DepartamentoViewModel { Id = model.Id, NombreDepartamento = model.NombreDepartamento });
            }
        }

        [HttpPost]
        public ActionResult Edit(DepartamentoViewModel model)
        {
            using (var context = new TareaEntities())
            {
                var modeldb = context.Departamento.Find(model.Id);
                modeldb.NombreDepartamento = model.NombreDepartamento;
                context.Entry(modeldb).State = EntityState.Modified;
                if (context.SaveChanges() > 0) return RedirectToAction("Index");
                else  ModelState.AddModelError("", "Error al guardar");
                return View(model);
                
            }
        }

        public ActionResult Delete(int Id)
        {
            using (var context = new TareaEntities())
            {
                var modeldb = context.Departamento.Find(Id);        
                context.Entry(modeldb).State = EntityState.Deleted;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }







    }
}