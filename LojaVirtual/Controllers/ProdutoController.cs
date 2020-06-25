using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Vizualizar()
        {
            Produto p = GetProduto();
            return View(p);
        }

        private static Produto GetProduto()
        {
            return new Produto(123, "Xbox one", "Jogue com prazer", 2500.25);
        }
    }
}
