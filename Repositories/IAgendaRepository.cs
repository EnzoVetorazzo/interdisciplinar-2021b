using System;
using System.Collections.Generic;
using Athletica.Models;

namespace Athletica.Repositories
{
    public interface IAgendaRepository
    {
        void Create(Agenda model);        
        Agenda Read(string nome, string senha);
        void Update(int id, Agenda model);
        void Delete(int id);
    }
}