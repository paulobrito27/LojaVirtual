using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult() { Content = "<h1>Deu certo</h1>" +
                "</br> <h3>Meu primeiro html</h3>" +
                "<button>Acessar</button>", ContentType = "text/html" };
        }
    }
}
