using CooperativaAgroCreativa.Models;
using CooperativaAgroCreativa.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rotativa.AspNetCore;
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

        [Authorize(Roles = "Administrador, Socio, Usuario")]
        public IActionResult SubmitOrder()
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int totalPrice = 0;
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var userCart = db.UserOrders.Where(d => d.UserId == usuario).FirstOrDefault();
            if (userCart == null || userCart.OrderProducts == "[]")
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
                }
                else
                {
                    productosNotFound.Add(elements);
                }
            }

            if (productosNotFound.Count() >= 1)
            {
                foreach (OrderProducts element in productosNotFound)
                {
                    userProducts.Remove(element);
                }

                userCart.OrderProducts = JsonConvert.SerializeObject(userProducts);
                db.SaveChanges();
            }

            ViewData["TotalPrice"] = totalPrice;
            return View(productos);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Finished()
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int totalPrice = 0;
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var userCart = db.UserOrders.Where(d => d.UserId == usuario).FirstOrDefault();

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
                }
                else
                {
                    productosNotFound.Add(elements);
                }
            }

            if (productosNotFound.Count() >= 1)
            {
                foreach (OrderProducts element in productosNotFound)
                {
                    userProducts.Remove(element);
                }

                userCart.OrderProducts = JsonConvert.SerializeObject(userProducts);
                db.SaveChanges();
            }

            OrdersCreated ordenCreate = new OrdersCreated();
            ordenCreate.Date = DateTime.Now;
            ordenCreate.Products = JsonConvert.SerializeObject(userProducts);
            ordenCreate.IdUser = usuario;
            ordenCreate.IsAcepted = 0;

            var CartDelete = db.UserOrders.Where(d => d.UserId == usuario).FirstOrDefault();
            db.OrdersCreateds.Add(ordenCreate);
            db.UserOrders.Remove(CartDelete);

            db.SaveChanges();

            OrdersCreated YaCreada = db.OrdersCreateds.Where(d => d == ordenCreate).FirstOrDefault();
            AspNetUser userInfo = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();
            
            HttpContext.Items["Mail"] = userInfo.UserName;
            HttpContext.Items["Phone"] = userInfo.Movil;
            HttpContext.Items["Id"] = YaCreada.Id;
            HttpContext.Items["Hour"] = YaCreada.Date.ToString();
            HttpContext.Items["TotalPrice"] = totalPrice;

            return new ViewAsPdf("Order", productos)
            {

            };
        }

        public IActionResult History()
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<OrdersCreated> orders = db.OrdersCreateds.Where(d => d.IdUser == usuario).ToList();
            return View(orders);
        }

        public IActionResult Finished(int id)
        {
            var usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            OrdersCreated order = db.OrdersCreateds.Where(d => d.IdUser == usuario && d.Id == id).FirstOrDefault();

            List<OrderProducts> userProducts = JsonConvert.DeserializeObject<List<OrderProducts>>(order.Products);
            List<Product> viewProducts = new List<Product>();

            int totalPrice = 0;

            foreach(var product in userProducts)
            {
                Product data = db.Products.Where(d => d.Id == Int32.Parse(product.ProductId)).FirstOrDefault();
                Product nuevo = new Product();
                nuevo.Id = Int32.Parse(product.ProductId);
                nuevo.Description = product.Talla;
                nuevo.Quantity = product.Quantity;
                nuevo.UnityPrice = data.UnityPrice;
                totalPrice += Int32.Parse(nuevo.UnityPrice) * nuevo.Quantity;
                viewProducts.Add(nuevo);
            }

            AspNetUser userInfo = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();

            HttpContext.Items["Mail"] = userInfo.UserName;
            HttpContext.Items["Phone"] = userInfo.Movil;
            HttpContext.Items["Id"] = order.Id;
            HttpContext.Items["Hour"] = order.Date.ToString();
            HttpContext.Items["TotalPrice"] = totalPrice;

            return new ViewAsPdf("Order", viewProducts)
            {

            };
        }
        
        public IActionResult AceptedOrder (IFormCollection form)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var order = db.OrdersCreateds.Find(Int32.Parse(form["Id"]));
            order.IsAcepted = 1;
            db.SaveChanges();
            return RedirectToAction("Orders", "Administrator");
        }

        public IActionResult RechazedOrder(IFormCollection form)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var order = db.OrdersCreateds.Find(Int32.Parse(form["Id"]));
            db.OrdersCreateds.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Orders", "Administrator");
        }
    }
}
