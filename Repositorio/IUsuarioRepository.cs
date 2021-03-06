using System.Collections.Generic;
using apitarefas.Models;

namespace apitarefas.Repositorio
{
    public interface IUsuarioRepository
    {
         void Add (Usuario user);

         IEnumerable<Usuario> GetAll();

         Usuario Find(long id);

         Usuario Find(string login, string senha);

         void Remove(long id);

         void Update(Usuario user);
    }
}