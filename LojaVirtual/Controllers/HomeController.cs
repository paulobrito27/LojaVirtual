﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CarrinhoCompras()
        {
            return View();
        }

        public ActionResult CadastroCliente()
        {
            return View();
        }
    }
}
