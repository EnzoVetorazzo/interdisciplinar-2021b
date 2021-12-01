using System;
using System.Collections.Generic;
using Athletica.Models;

namespace Athletica.Repositories
{
    public interface IAgendamentosRepository
    {
        Boolean Create(Agendamentos objAgendamentos);        
        List<Agendamentos> Read();
        List<Agendamentos> Find(string nome);
        Agendamentos FindById(int id);
        Boolean Update(Agendamentos objAgendamentos);
        void Delete(int id);
    }
}