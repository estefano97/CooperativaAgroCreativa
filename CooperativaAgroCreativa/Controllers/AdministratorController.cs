using CooperativaAgroCreativa.Data;
using CooperativaAgroCreativa.Models.DB;
using CooperativaAgroCreativa.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaAgroCreativa.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly RoleManager<IdentityRole> RoleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministratorController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.RoleManager = roleManager;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Index()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var users = userManager.Users.Where(d => d.EmailConfirmed == false).ToList();
            var usuariosVista = userManager.Users.Where(d => d.EmailConfirmed == true).ToList();
            ViewBag.UsuariosCompleto = usuariosVista;
            return View(users);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult CreateRole()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public async Task<IActionResult> ConfirmUser(string id)
        {
            var user = userManager.Users.Where(d => d.Id == id).FirstOrDefault();
            user.EmailConfirmed = true;
            var result = await userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                var db = new CoopeCreativa_RLContext();
                AspNetUserRole userRole = new AspNetUserRole();
                var idRol = db.AspNetRoles.Where(d => d.Name == user.Role).FirstOrDefault();
                userRole.UserId = user.Id;
                userRole.RoleId = idRol.Id;
                db.AspNetUserRoles.Add(userRole);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index", "Administrator");
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await RoleManager.CreateAsync(identityRole);
            
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Orders ()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<OrdersCreated> ordenes = db.OrdersCreateds.Where(d => d.IsAcepted == 0).ToList();
            return View(ordenes);
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult OrdersAcepted()
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            List<OrdersCreated> ordenes = db.OrdersCreateds.Where(d => d.IsAcepted == 1).ToList();
            return View(ordenes);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult DeleteUser(string id)
        {
            var db = new CoopeCreativa_RLContext();
            var user = db.AspNetUsers.Where(d => d.Id == id).FirstOrDefault();
            db.AspNetUsers.Remove(user);
            db.SaveChanges();

            return RedirectToAction("Index", "Administrator");
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult ChangeRoleUser(IFormCollection form)
        {
            ViewData["idUser"] = form["id"];
            ViewData["nameUser"] = form["name"];
            return View();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult ChangeRolUserConfirm(IFormCollection form)
        {
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var userRol = db.AspNetUserRoles.Where(d => d.UserId == form["idUser"].ToString()).FirstOrDefault();
            db.AspNetUserRoles.Remove(userRol);
            AspNetUser dataUser = db.AspNetUsers.Where(d => d.Id == form["idUser"].ToString()).FirstOrDefault();
            dataUser.EmailConfirmed = false;
            dataUser.Role = form["newRol"];
            db.SaveChanges();
            return RedirectToAction("Index", "Administrator");
        }

    }
}
