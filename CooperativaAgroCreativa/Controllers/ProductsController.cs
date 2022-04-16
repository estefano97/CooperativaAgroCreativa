using CooperativaAgroCreativa.Data;
using CooperativaAgroCreativa.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Security.Claims;
using Newtonsoft.Json;

namespace CooperativaAgroCreativa.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductsController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<Product> Productos = db.Products.ToList();
            return View(Productos);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Admin()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<Product> Productos = db.Products.ToList();
            return View(Productos);
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
            Product nuevo = new Product();
            nuevo.Description = form["Description"];
            nuevo.Quantity = Int32.Parse(form["Quantity"]);
            nuevo.UnityPrice = form["UnityPrice"];
            nuevo.State = form["State"];
            nuevo.Sizes = Int32.Parse(form["Sizes"]);
            nuevo.Image = "/assets/productos/default.png";
            nuevo.Date = DateTime.Now;
            db.Products.Add(nuevo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Edit(int id)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Product Producto = db.Products.Where(e => e.Id == id).FirstOrDefault();
            return View(Producto);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Delete(int id)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Product Producto = db.Products.Where(e => e.Id == id).FirstOrDefault();
            return View(Producto);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult DeletePost(int Id)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Product Producto = db.Products.Find(Id);
            db.Products.Remove(Producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult EditPost(IFormCollection editado)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Product Producto = db.Products.Where(e => e.Id == Int32.Parse(editado["Id"])).FirstOrDefault();
            Producto.Description = editado["Description"];
            Producto.Quantity = Int32.Parse(editado["Quantity"]);
            Producto.UnityPrice = editado["UnityPrice"];
            Producto.Sizes = Int32.Parse(editado["Sizes"]);
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
            var path = Path.Combine(webRoute, "assets/productos", FileName);
            using (FileStream fs = System.IO.File.Create(path))
            {
                foto.CopyTo(fs);
            }
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            Product Producto = db.Products.Where(e => e.Id == Id).FirstOrDefault();
            Producto.Image = $"/assets/productos/{FileName}";
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
