using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Athletica.Models;
using System.Linq;
using Athletica.Repositories;

namespace Athletica.Controllers
{    
    public class UsuarioController : Controller
    {
        private IUsuarioRepository repository;

        public UsuarioController(IUsuarioRepository repository) 
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        
    }
}