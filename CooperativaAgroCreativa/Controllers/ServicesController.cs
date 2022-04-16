using CooperativaAgroCreativa.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CooperativaAgroCreativa.Controllers
{
    public class ServicesController : Controller
    {

        private readonly IWebHostEnvironment _hostingEnvironment;

        public ServicesController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<Service> services = db.Services.ToList();
            return View(services);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Admin()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<Service> services = db.Services.ToList();
            return View(services);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult CreatePost(IFormCollection form)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Service nuevo = new Service();
            nuevo.Title = form["title"];
            nuevo.Price = Int32.Parse(form["price"]);
            nuevo.Description = form["description"];
            nuevo.Image = "/assets/productos/default.png";
            db.Services.Add(nuevo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Edit(int id)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Service servicio = db.Services.Where(e => e.Id == id).FirstOrDefault();
            return View(servicio);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Delete(int id)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Service servicio = db.Services.Where(e => e.Id == id).FirstOrDefault();
            return View(servicio);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult DeletePost(int Id)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Service servicio = db.Services.Find(Id);
            db.Services.Remove(servicio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult EditPost(IFormCollection editado)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Service servicios = db.Services.Where(e => e.Id == Int32.Parse(editado["Id"])).FirstOrDefault();
            servicios.Title = editado["title"];
            servicios.Price = Int32.Parse(editado["price"]);
            servicios.Description = editado["description"];
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult EditImage(IFormFile foto, int Id)
        {
            var FileName = Path.GetFileName(foto.FileName);
            var webRoute = _hostingEnvironment.WebRootPath;
            var fileRoute = _hostingEnvironment.ContentRootPath;
            var path = Path.Combine(webRoute, "assets/servicios", FileName);
            using (FileStream fs = System.IO.File.Create(path))
            {
                foto.CopyTo(fs);
            }
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
           Service servicios = db.Services.Where(e => e.Id == Id).FirstOrDefault();
            servicios.Image = $"/assets/servicios/{FileName}";
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
