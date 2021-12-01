using System;
using System.Collections.Generic;
using Athletica.Models;

namespace Athletica.Repositories
{
    // "Contrato" ("Abstrato")
    public interface IFuncionarioRepository
    {
        void Create(Funcionario model);        
        Funcionario Read(string nome, string senha);
        void Update(int id, Funcionario model);
        void Delete(int id);
    }
}