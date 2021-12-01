using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Athletica.Models;
using System.Linq;
using Athletica.Repositories;

namespace Athletica.Controllers
{    
    public class FuncionarioController : Controller
    {
        private IFuncionarioRepository repository;

        public FuncionarioController(IFuncionarioRepository repository) 
        {
            this.repository = repository;
        }
        
        // http://localhost/Todo/Index = return new TodoController().Index()
    }
}