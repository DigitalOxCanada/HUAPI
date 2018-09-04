using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using HUAPICore.Services.Interfaces;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HUAPICore.Services
{
    public class SMSExchangeService : SMSServiceBase, ISMSService
    {

        private IOptions<CustomConfig> _cfg { get; }
        public readonly ISettings _settings;
        private HUAPIDBContext _context;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        public SMSExchangeService(IOptions<CustomConfig> cfg, HUAPIDBContext ctx, ISettings settings) : base(cfg)
        {
            _cfg = cfg;
            _context = ctx;
            _settings = settings;
        }

        static bool RedirectionCallback(string url)
        {
            // Return true if the URL is an HTTPS URL.
            return url.ToLower().StartsWith("https://");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="message"></param>
        /// <param name="region"></param>
        /// <param name="when"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task SendMessage(string number, string message, string region, DateTime when)
        {
            // if not IsLive bail
            if (!Convert.ToBoolean(_settings.Settings["IsLive"]))
            {
                return;
            }

            number = CleanPhone(number);
            number = CheckTheTestMode(number);

            ExchangeService service = new ExchangeService();
            service.Credentials = new System.Net.NetworkCredential(_cfg.Value.SystemConfig.SMSService.Exchange.Email, _cfg.Value.SystemConfig.SMSService.Exchange.Pwd);
            service.AutodiscoverUrl(_cfg.Value.SystemConfig.SMSService.Exchange.Email, RedirectionCallback);

            EmailMessage messagebody = new EmailMessage(service);
            //messagebody.Subject = "my subject";
            messagebody.Body = message;
            messagebody.ToRecipients.Add($"{number}@txt.bell.ca"); //TODO go through the list of call carriers
            await messagebody.Save();

            await messagebody.Send(); //.SendAndSaveCopy();


            ////This code will allow you to accept invalid certificates.
            ////this is a very BAD practice, and should only use for testing purposes. It is a security risk!
            //ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            //SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            //client.TargetName = "STARTTLS/smtp.office365.com";
            //client.EnableSsl = true;
            //client.Credentials = new System.Net.NetworkCredential("perry@digitalox.ca", _cfg["o365:pwd"]);
            //MailAddress from = new MailAddress("support@digitalox.ca", String.Empty, System.Text.Encoding.UTF8);
            //MailAddress to = new MailAddress("7059896112@txt.bell.ca");
            //MailMessage messagebody = new MailMessage(from, to);
            //messagebody.Body = "testing";
            //messagebody.BodyEncoding = System.Text.Encoding.UTF8;
            ////messagebody.Subject = "";
            ////messagebody.SubjectEncoding = System.Text.Encoding.UTF8;
            //// Set the method that is called back when the send operation ends.
            ////client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            //// The userState can be any object that allows your callback 
            //// method to identify this send operation.
            //// For this example, I am passing the message itself
            ////client.SendAsync(message, message);

            //client.Send(messagebody);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the message we sent
            MailMessage msg = (MailMessage)e.UserState;

            if (e.Cancelled)
            {
                // prompt user with "send cancelled" message 
            }
            if (e.Error != null)
            {
                // prompt user with error message 
            }
            else
            {
                // prompt user with message sent!
                // as we have the message object we can also display who the message
                // was sent to etc 
            }

            // finally dispose of the message
            if (msg != null)
                msg.Dispose();
        }
    }
}
