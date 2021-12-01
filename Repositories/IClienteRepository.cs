using System;
using System.Collections.Generic;
using Athletica.Models;

namespace Athletica.Repositories
{
    // "Contrato" ("Abstrato")
    public interface IClienteRepository
    {
        void Create(Cliente model);        
        Cliente Read(string nome, string senha);
        Cliente ReadCheck(string nome, string senha);
        void Update(int id, Cliente model);
        void Delete(int id);
    }
}