using CooperativaAgroCreativa.Models;
using CooperativaAgroCreativa.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace CooperativaAgroCreativa.Controllers
{
    public class OrdersController : Controller
    {
        [Authorize(Roles = "Administrador, Socio, Usuario")]
        public IActionResult Index()
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int totalPrice = 0;
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var userCart = db.UserOrders.Where(d => d.UserId == usuario).FirstOrDefault();
            if(userCart == null || userCart.OrderProducts == "[]")
            {
                ViewBag.HayValores = false;
                return View();
            }

            ViewBag.HayValores = true;
            List<OrderProducts> userProducts = JsonConvert.DeserializeObject<List<OrderProducts>>(userCart.OrderProducts);
            List<OrderProducts> productosNotFound = new List<OrderProducts>();
            List<Product> productos = new List<Product>();
            foreach (OrderProducts elements in userProducts)
            {
                if (db.Products.Where(d => d.Id == Int32.Parse(elements.ProductId)).Count() != 0)
                {
                    Product data = db.Products.Where(d => d.Id == Int32.Parse(elements.ProductId)).FirstOrDefault();
                    Product element = new Product();

                    element.Id = data.Id;
                    element.UnityPrice = data.UnityPrice;
                    element.Image = data.Image;
                    element.Description = elements.Talla;
                    element.Quantity = elements.Quantity;
                    productos.Add(element);

                    totalPrice += Int32.Parse(data.UnityPrice) * element.Quantity;
                } else
                {
                    productosNotFound.Add(elements);
                }
            }

            if(productosNotFound.Count() >= 1)
            {
                foreach(OrderProducts element in productosNotFound)
                {
                    userProducts.Remove(element);
                }

                userCart.OrderProducts = JsonConvert.SerializeObject(userProducts);
                db.SaveChanges();
            }

            ViewData["TotalPrice"] = totalPrice;
            return View(productos);
        }

        [Authorize(Roles = "Administrador, Socio, Usuario")]
        [HttpPost]
        public IActionResult AddProductOrder(IFormCollection form)
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var idProduct = form["Id"];
            var tallaProduct = form["Talla"]; 
            UserOrder userInfo = db.UserOrders.Where(d => d.UserId == usuario).FirstOrDefault();

            if (userInfo != null)
            {
                List<OrderProducts> datosUser = JsonConvert.DeserializeObject<List<OrderProducts>>(userInfo.OrderProducts);
                foreach(OrderProducts product in datosUser)
                {
                    if(product.ProductId.ToString() == idProduct && product.Talla.ToString() == tallaProduct)
                    {
                        product.Quantity++;
                        userInfo.OrderProducts = JsonConvert.SerializeObject(datosUser);
                        db.SaveChanges();
                        if(form["Redirect"] == "Orders")
                        {
                            return RedirectToAction("Index", "Orders");
                        }
                        return RedirectToAction("Index", "Products");
                    }
                }

                OrderProducts productoAgregado = new OrderProducts();
                productoAgregado.ProductId = idProduct;
                productoAgregado.Talla = tallaProduct;
                productoAgregado.Quantity = 1;
                datosUser.Add(productoAgregado);
                userInfo.OrderProducts = JsonConvert.SerializeObject(datosUser);
                db.SaveChanges();
                return RedirectToAction("Index", "Products");
            }
            else
            {
                List<OrderProducts> datosUser = new List<OrderProducts>();
                OrderProducts productoAgregado = new OrderProducts();
                productoAgregado.ProductId = idProduct;
                productoAgregado.Quantity = 1;
                productoAgregado.Talla = tallaProduct;
                datosUser.Add(productoAgregado);

                UserOrder newOrder = new UserOrder();
                newOrder.UserId = usuario;
                newOrder.OrderProducts = JsonConvert.SerializeObject(datosUser);
                db.UserOrders.Add(newOrder);
                db.SaveChanges();
                return RedirectToAction("Index", "Products");
            }
        }

        [Authorize(Roles = "Administrador, Socio, Usuario")]
        [HttpPost]
        public IActionResult RestProductOrder(IFormCollection form)
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var idProduct = form["Id"];
            var tallaProduct = form["Talla"];
            UserOrder userInfo = db.UserOrders.Where(d => d.UserId == usuario).FirstOrDefault();

            if (userInfo != null)
            {
                List<OrderProducts> datosUser = JsonConvert.DeserializeObject<List<OrderProducts>>(userInfo.OrderProducts);
                foreach (OrderProducts product in datosUser)
                {
                    if (product.ProductId.ToString() == idProduct && product.Talla.ToString() == tallaProduct)
                    {
                        if(product.Quantity == 1)
                        {
                            datosUser.Remove(product);
                        }
                        product.Quantity--;
                        userInfo.OrderProducts = JsonConvert.SerializeObject(datosUser);
                        db.SaveChanges();
                        if (form["Redirect"] == "Orders")
                        {
                            return RedirectToAction("Index", "Orders");
                        }
                        return RedirectToAction("Index", "Products");
                    }
                }

                OrderProducts productoAgregado = new OrderProducts();
                productoAgregado.ProductId = idProduct;
                productoAgregado.Talla = tallaProduct;
                productoAgregado.Quantity = 1;
                datosUser.Add(productoAgregado);
                userInfo.OrderProducts = JsonConvert.SerializeObject(datosUser);
                db.SaveChanges();
                return RedirectToAction("Index", "Products");
            }
            else
            {
                List<OrderProducts> datosUser = new List<OrderProducts>();
                OrderProducts productoAgregado = new OrderProducts();
                productoAgregado.ProductId = idProduct;
                productoAgregado.Quantity = 1;
                productoAgregado.Talla = tallaProduct;
                datosUser.Add(productoAgregado);

                UserOrder newOrder = new UserOrder();
                newOrder.UserId = usuario;
                newOrder.OrderProducts = JsonConvert.SerializeObject(datosUser);
                db.UserOrders.Add(newOrder);
                db.SaveChanges();
                return RedirectToAction("Index", "Products");
            }
        }

    }
}
