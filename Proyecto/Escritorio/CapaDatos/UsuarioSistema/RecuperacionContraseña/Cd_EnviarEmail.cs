using System.Net;
using System.Net.Mail;

namespace CapaDatos.UsuarioSistema.RecuperacionContraseña
{
    public abstract class Cd_EnviarEmail
    {
        protected SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected Cd_EnviarEmail() // Constructor de la clase "Cd_EnviarEmail"
        {
            senderMail = "villamizarmedina@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InitializeSmtpClient();
        }

        // Inicializar propiedades del cliente SMTP
        protected void InitializeSmtpClient() // Metodo que inicializa las propiedades de la clase "SmtpClient"
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public async Task EnviarCorreoRecuperacion(string subject, string body, string mail) // Metodo que se encarga de enviar el correo electronico
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                try
                {
                    mailMessage.From = new MailAddress(senderMail);
                    mailMessage.To.Add(mail);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;
                    mailMessage.Priority = MailPriority.Normal;
                    smtpClient.Send(mailMessage); // Enviar mensaje

                    await Task.Delay(5000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
