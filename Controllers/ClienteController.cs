using Microsoft.AspNetCore.Mvc;
using Athletica.Models;
using Athletica.Repositories;
using Microsoft.AspNetCore.Http;
using System;

namespace Athletica.Controllers
{
    // localhost:5000/usuario/
    public class ClienteController: Controller
    {
        private IClienteRepository repository;

        // injeção de dependência.
        public ClienteController(IClienteRepository repository)
        {
            this.repository = repository;
        }

        // localhost:5000/usuario/login
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Acesso = 1;
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }        

        [HttpGet]
        public ActionResult Menu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar(string nome_login_feito, string senha_feita_cad)
        {

            Cliente objCliente = repository.ReadCheck(nome_login_feito, senha_feita_cad);

            if (objCliente.Nome == nome_login_feito && objCliente.Senha == senha_feita_cad)
            {
                //return Json(new { Msg = "Usuário logado com Sucesso!!" });
                // Cria-se uma sessão para o usuário e,
                //HttpContext.Session.SetInt32("id", (int)objCliente.Id);
                //HttpContext.Session.SetString("nome", objCliente.Nome);

                return RedirectToAction("Menu");
                //return RedirectToAction("Agenda", "Agendamentos");
            }
            else
            {
                ViewBag.Acesso = -1;
                return View("login");
            }
        }

        /*[HttpPost]
        public ActionResult Login(UsuarioLoginViewModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            Cliente usuario = repository.Read(model.Email, model.Senha);

            if(usuario == null)
            {
                ViewBag.Message = "Usuário não encontrado.";
                return View(model);
            }

            // Cria-se uma sessão para o usuário e,
            HttpContext.Session.SetInt32("id", (int)usuario.Id);
            HttpContext.Session.SetString("nome", usuario.Nome);

            return RedirectToAction("Index", "Todo");
        }*/

        [HttpPost]
        public ActionResult Cadastrar(Cliente model)
        {

            repository.Create(model);
            return RedirectToAction("Login");

        }
    }
}