using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea1Cruds_LuisGonzalez.DB;

namespace Tarea1Cruds_LuisGonzalez.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {

            using (var context = new ModelDBContainer())
            {
                var list = context.DepartamentoSet.ToList();
                return View(list);
            }
                
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Departamento model)
        {
            using (var context = new ModelDBContainer())
            {
                context.DepartamentoSet.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }





    }
}