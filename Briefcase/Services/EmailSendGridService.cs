using Briefcase.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Briefcase.Services
{
    public interface IEmailSendGrisService
    {
        Task Enviar(Contact contact);
    }
    public class EmailSendGridService:IEmailSendGrisService 
    {
        private readonly IConfiguration configuration;

        public EmailSendGridService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(Contact contact)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var name = configuration.GetValue<string>("SENDGRID_NAME");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, name);
            var subject = $"The Person {contact.Name} is contacting you by SendGrid";
            var to = new EmailAddress(email, name);
            var messge = contact.Message;
            var HtmlContent = $@"From: {contact.Name} - Email:{contact.Email} - Message: {contact.Message} ";

            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, messge, HtmlContent);
            await cliente.SendEmailAsync(singleEmail);
        }
    }
}
