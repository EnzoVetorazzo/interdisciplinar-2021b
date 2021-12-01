using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Athletica.Models;
using System.Linq;
using Athletica.Repositories;

namespace Athletica.Controllers
{    
    public class AgendaController : Controller
    {
        private IAgendaRepository repository;

        public AgendaController(IAgendaRepository repository) 
        {
            this.repository = repository;
        }
        
        /*public ActionResult Agenda()
        {
            return view();
        }*/
        
    }
}