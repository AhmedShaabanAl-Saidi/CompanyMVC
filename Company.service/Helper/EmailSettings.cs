using System.Net;
using System.Net.Mail;

namespace Company.service.Helper
{
    public class EmailSettings
    {
        public static void SendEmail(Email input)
        {
            var client = new SmtpClient("smtp.gmail.com" , 587);

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("ahmedshaaban123321@gmail.com", "oqfpidqjlushqgex");

            client.Send("ahmedshaaban123321@gmail.com", input.To, input.Subject, input.Body);
        }
    }
}
