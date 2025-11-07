using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace Server.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpHost = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private readonly string _fromEmail;
        private readonly string _appPassword;
        public EmailSender(string fromEmail, string appPassword) 
        {
            _appPassword = appPassword;
            _fromEmail = fromEmail;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using var client = new SmtpClient(_smtpHost, _smtpPort)
            {
                Credentials = new NetworkCredential(_fromEmail, _appPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage(_fromEmail, email, subject, htmlMessage)
            {
                IsBodyHtml = true
            };
            // Implement your email sending logic here.
            // This could involve using an SMTP client or a third-party email service API.
            //Console.WriteLine($"Sending email to {email} with subject '{subject}' and message: {message}\n");
            await client.SendMailAsync(mailMessage);
        }
    }
}
