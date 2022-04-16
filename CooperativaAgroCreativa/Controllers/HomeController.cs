using CooperativaAgroCreativa.Data;
using CooperativaAgroCreativa.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CooperativaAgroCreativa.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendForm(IFormCollection form)
        {
            string EmailOrigen = "thehatfactorysoftware@gmail.com";
            string EmailDestino = "oldemarcr@gmail.com";
            string Password = "4Y!REMqpoa1I";

            string cabezera = $"Formulario enviado por {form["nombre"]}.";

            string cuerpo = $"<b>Email del solicitante:</b> {form["correo"]}." +
                $"<br><b>Dirección del solicitante:</b> {form["direccion"]}." +
                $"<br><br><b>Comentarios:</b><br> {form["comentarios"]}.";

            MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, cabezera, cuerpo);

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.Host = "smtp.gmail.com";
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Password);
            oSmtpClient.Send(oMailMessage);
            oSmtpClient.Dispose();

            return View("Index");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
