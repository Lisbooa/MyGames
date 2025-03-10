using Microsoft.AspNetCore.Mvc;
using MyGames.ViewModels;
using System.Net;
using System.Net.Mail;

namespace MyGames.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendContact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["message"] = "Dados inválidos!";
                return View("Index", model);
            }
            var emailMessage = new MailMessage();
            emailMessage.Subject = "Contato de " + model.Name;
            emailMessage.From = new MailAddress("joselaevertonlisboa@gmail.com");
            emailMessage.To.Add("joselaevertonlisboa@gmail.com");
            emailMessage.IsBodyHtml = true;
            emailMessage.Body = "<p>Nome: " + model.Name + "</p><p>Email: " + model.Email + "</p>" +
                "<p>Mensagem: " + model.Message + "</p>";
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("joselaevertonlisboa@gmail.com", "rmcmhxypivvslebv");
            client.EnableSsl = true;

            try
            {
                client.Send(emailMessage);
            }
            catch(Exception ex)
            {
                ViewData["message"] = "Falha ao enviar email!" + ex.Message;
                return View("Index", model);
            }
            return View();
        }
    }
}
