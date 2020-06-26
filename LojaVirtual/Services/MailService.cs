
using LojaVirtual.Models;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace LojaVirtual.Services
{
    public class MailService
    {
        public static void EnviaEmail(Contato contato)
        {
            //Configurando Smtp
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("paulojmbrito27@gmail.com", "Pjmbrito271080");
            smtp.EnableSsl = true;

            //Corpo da mensagem
            string corpoMensagem = string.Format(" Confirmação de contato \n\n " +
                " Nome: {0} \n " +
                " Email: {1} \n\n " +
                " Texto:\n {2} \n\n\n " +
                " esta mensagem é enviada automaticamente ",
                contato.Nome,
                contato.Email,
                contato.Texto
                );

            //Configurando mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("paulojmbrito27@gmail.com");
            mensagem.To.Add(contato.Email);
            mensagem.Subject = "Mensagem de teste da LojaVirtual";
            mensagem.Body = corpoMensagem ;


            //enviando a mensagem
            smtp.Send(mensagem);
        }
    }
}
