using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Athletica.Models;
using System.Linq;
using Athletica.Repositories;

namespace Athletica.Controllers
{    
    public class ServicosController : Controller
    {
        private IServicosRepository repository;

        public ServicosController(IServicosRepository repository) 
        {
            this.repository = repository;
        }
        
        public ActionResult agendamento_Servico(int feedback)
        {
            ViewBag.Feedback = feedback;
            var servicos = repository.Read();
            return View(servicos);
        }
    }
}