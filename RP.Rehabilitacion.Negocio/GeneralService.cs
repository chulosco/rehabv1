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

namespace RP.Rehabilitacion.Negocio
{
    public class GeneralService
    {

        SIGH_RPEntities context = new SIGH_RPEntities();

        public IEnumerable<USP_ObtenerMaestro_Result> obtenerMaestro(string maestroDesc)
        {
            return context.USP_ObtenerMaestro(maestroDesc);
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
