using System;
namespace Athletica.Models
{
    public class Agendamentos
    {
        public int Id { get; set; }
        public int? Fgk_servicos {get; set;}
        public DateTime Hora_inicio { get; set; }
        public DateTime Hora_fim { get; set; }
        public string Nome { get; set; }
        public string NomeServico { get; set; }
        public int CodServico { get; set; }
    }
}