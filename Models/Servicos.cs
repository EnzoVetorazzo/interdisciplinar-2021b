namespace Athletica.Models
{
    public class Servicos
    {
        public int Id { get; set; }
        public int? Fgk_funcionario {get; set;}
        public string Nome { get; set; }
        public string Dias {get; set;}
        public string Horarios {get; set;}
        public string Duracao { get; set; }
    }
}