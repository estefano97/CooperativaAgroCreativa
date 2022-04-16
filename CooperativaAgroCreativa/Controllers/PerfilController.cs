using CooperativaAgroCreativa.Data;
using CooperativaAgroCreativa.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CooperativaAgroCreativa.Controllers
{
    public class PerfilController : Controller
    {
        private readonly RoleManager<IdentityRole> RoleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public PerfilController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.RoleManager = roleManager;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            string usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewData["IdUser"] = usuario;
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            AspNetUser dataUser = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();
            return View(dataUser);
        }

        [Authorize]
        public IActionResult ChangeInfo()
        {
            string usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            AspNetUser dataUser = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();
            return View(dataUser);
        }

        [Authorize]
        public IActionResult ChangeRole()
        {
            string usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            AspNetUser dataUser = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();
            return View(dataUser);
        }

        [Authorize]
        [HttpPost]
        public IActionResult ChangeInfoConfirm(IFormCollection form)
        {
            string usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            AspNetUser dataUser = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();
            dataUser.FullName = form["name"];
            dataUser.Direction = form["direction"];
            dataUser.Movil = form["mobile"];
            db.SaveChanges();
            return RedirectToAction("Index", "Perfil");
        }

        [Authorize]
        [HttpPost]
        public IActionResult ChangeRolConfirm(IFormCollection form)
        {
            string usuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            CoopeCreativa_RLContext db = new CoopeCreativa_RLContext();
            var userRol = db.AspNetUserRoles.Where(d => d.UserId == usuario).FirstOrDefault();
            db.AspNetUserRoles.Remove(userRol);
            AspNetUser dataUser = db.AspNetUsers.Where(d => d.Id == usuario).FirstOrDefault();
            dataUser.EmailConfirmed = false;
            dataUser.Role = form["newRol"];
            db.SaveChanges();
            return RedirectToAction("Index", "Perfil");
        }

    }
}
