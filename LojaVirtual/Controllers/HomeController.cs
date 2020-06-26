
using LojaVirtual.Models;
using LojaVirtual.Services;
using Microsoft.AspNetCore.Mvc;


namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            Contato contato = new Contato();
            contato.Nome = HttpContext.Request.Form["nome"];
            contato.Email = HttpContext.Request.Form["email"];
            contato.Texto = HttpContext.Request.Form["texto"];

            //MailService.EnviaEmail(contato);

            ViewData["MSG"] = "Mensagem enviada com sucesso!";

            return View("Contato"); 
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
