using System;
using System.Collections.Generic;
using Athletica.Models;

namespace Athletica.Repositories
{
    public interface IUsuarioRepository
    {
        void Create(Usuario model);        
        Usuario Read(string nome, string senha);
        void Update(int id, Usuario model);
        void Delete(int id);
    }
}