using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Athletica.Models;
using System.Linq;
using Athletica.Repositories;

namespace Athletica.Controllers
{    
    public class AgendamentosController : Controller
    {
        private IAgendamentosRepository repository;

        public AgendamentosController(IAgendamentosRepository repository) 
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult FrmAlterarAgendamentos(int id)
        {
            List<Agendamentos> lstAgendamentosServicos = new List<Agendamentos>();
            lstAgendamentosServicos = repository.Read();

            Agendamentos objAgendamentos = new Agendamentos();
            objAgendamentos = repository.FindById(id);

            ViewBag.lstAgendamentosServicos = lstAgendamentosServicos;
            ViewBag.objAgendamentos = objAgendamentos;
            return View();
        }

        public ActionResult Agenda()
        {
            var agendamentos = repository.Read();
            return View(agendamentos);
        }
        
        public ActionResult FrmBuscarHorariosAgendados(int feedback)
        {
            ViewBag.Feedback = feedback;
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar (string servico, string nome, string data, string horario_inicio, string horario_fim)
        {
            Agendamentos objAgendamentos = new Agendamentos();

            objAgendamentos.Fgk_servicos = Convert.ToInt16(servico);
            objAgendamentos.Nome = nome;
            objAgendamentos.Hora_inicio = Convert.ToDateTime(data + "T" + horario_inicio);
            objAgendamentos.Hora_fim = Convert.ToDateTime(data + "T" + horario_fim);

            if (repository.Create(objAgendamentos))
            {                
                return RedirectToAction("agendamento_Servico", "Servicos", new {feedback = 1});
            }
            else
            {
                return Json(new { Msg = "Erro no Cadastro de Agendamento!"});
            }            
        }

        [HttpPost]
        public ActionResult BuscarAgendamentos (string nome)
        {   

            List<Agendamentos> lstAgendamentos = new List<Agendamentos>();
            lstAgendamentos = repository.Find(nome);

            ViewBag.LstAgendamentos = lstAgendamentos;
            return View("MeusAgendamentos");
        }

        [HttpPost]
        public ActionResult AtualizarAgendamento (string id, string servico, string nome, string data, string horario_inicio, string horario_fim)
        {
            Agendamentos objAgendamentos = new Agendamentos();

            objAgendamentos.Id = Convert.ToInt32(id);
            objAgendamentos.Fgk_servicos = Convert.ToInt32(servico);
            objAgendamentos.Nome = nome;
            objAgendamentos.Hora_inicio = Convert.ToDateTime(data + "T" + horario_inicio);
            objAgendamentos.Hora_fim = Convert.ToDateTime(data + "T" + horario_fim);

            if (repository.Update(objAgendamentos))
            {
                return RedirectToAction("FrmBuscarHorariosAgendados", new {feedback = 1});
            }
            else
            {
                return Json(new { Msg = "Erro ao Atualizar Agendamento!"});
            }        
        }


    }
}