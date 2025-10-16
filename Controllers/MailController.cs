using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ShoppingMongo.Models;

namespace ShoppingNightMongo.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(MailViewModel mailViewModel)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Coza Store", "emredurak044@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", mailViewModel.Email));

            mimeMessage.Subject = "Hoş Geldiniz! %20 İndirim Kuponunuz";

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = "<h2>Teşekkürler!</h2><p>Bültenimize abone olduğunuz için %20 indirim kuponunuz hazır:</p><h3>Kupon Kodu: <strong>XYZ20</strong></h3><p>İyi alışverişler!</p>"
            };

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate("emredurak044@gmail.com", "pkmp eyds xnlo aqrn");
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}