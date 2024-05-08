using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EmailServices
    {
        private MailMessage email;
        private SmtpClient server;


        public EmailServices()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("useralecito@gmail.com", "yenf vvhh tglp jyqx");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo(string emaildestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@alecito.com");
            //email.To.Add(emaildestino);
            email.To.Add(emaildestino);//quien va recibir el mail
            email.Subject = asunto;
            email.IsBodyHtml = false;
            //email.Body = "<html>" +
            //    "<head>" +
            //        "<style>" +
            //            "h1 {color: #000; font-size: 24px;}" + // Estilo básico para el encabezado h1
            //        "</style>" +
            //    "</head>" +
            //    "<body>" +
            //        "<h1>Responder al siguiente mail:</h1>" +
            //        "<h4>" + emaildestino.ToString() + "</h4>" +
            //        "<h3>"+ cuerpo + "</h3>"+// Contenido del correo electrónico
            //    "</body>" +
            //"</html>";



            email.Body = cuerpo;
        }

        public void enviarMail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
