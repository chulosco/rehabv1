using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace RP.Rehabilitacion.Negocio
{
    public class GeneralService
    {

        SIGH_RPEntities context = new SIGH_RPEntities();

        public IEnumerable<USP_ObtenerMaestro_Result> obtenerMaestro(string maestroDesc)
        {
            return context.USP_ObtenerMaestro(maestroDesc);
        }

        public IEnumerable<USP_ListarAgentesRecomendados_Result>  ListarAgentesRecomendados(int idDiagnostico)
        {
            return context.USP_ListarAgentesRecomendados(idDiagnostico);
        }



        public void enviarRecordatorioTerapiaSms(string nroTelefono, string fecha, string nomMedico, string sala) 
        {

            const string accountSid = "ACd427c0026a8ee3cc03d82f9eb68e2137";
            const string authToken = "4835d2b1866375c0111767398156a166";
            TwilioClient.Init(accountSid, authToken);

            var mediaUrl = new List<Uri>();
            {
                new Uri("http://drmauricioleon.net/web/images/CLINICA_RICARDO_PALMA.jpg");
            };
            var to = new PhoneNumber("+51966700445");
            var message = MessageResource.Create(
              to,
              from: new PhoneNumber("+19093774281"),
              body: "Recuerde que tiene su cita de terapia el día " + fecha + " con el terapista " + nomMedico +  " en la sala " + sala + ". Clinica Ricardo Palma",
              mediaUrl: mediaUrl);
            Console.WriteLine(message.Sid);
        }

        public void enviarRecordatorioTerapiaEmail()
        {
            var fromAddress = new MailAddress("dari3ndoomed@gmail.com", "From Name");
            var toAddress = new MailAddress("dari3ndoomed@example.com", "To Name");
            const string fromPassword = "d@rk3stdari3n";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

    public void testTwilio()
        {
            const string accountSid = "ACd427c0026a8ee3cc03d82f9eb68e2137";
            const string authToken = "4835d2b1866375c0111767398156a166";
            TwilioClient.Init(accountSid, authToken);

            var mediaUrl = new List<Uri>();
            {
                new Uri("https://climacons.herokuapp.com/clear.png");
            };
            var to = new PhoneNumber("+51966700445");
            var message = MessageResource.Create(
              to,
              from: new PhoneNumber("+19093774281"),
              body: "Tomorrow's forecast in Financial District, San Francisco is Clear",
              mediaUrl: mediaUrl);
            Console.WriteLine(message.Sid);

        }

    }
}
