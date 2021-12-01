using System;
using System.Collections.Generic;
using Athletica.Models;

namespace Athletica.Repositories
{
    public interface IServicosRepository
    {
        void Create(Servicos model);        
        List<Servicos> Read();
        void Update(int id, Servicos model);
        void Delete(int id);
    }
}