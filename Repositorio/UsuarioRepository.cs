using System.Collections.Generic;
using System.Linq;
using apitarefas.Models;

namespace apitarefas.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BancoContext db;
        public UsuarioRepository(BancoContext dbContext)
        {
            db = dbContext;
        }
        public void Add(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

        public Usuario Find(long id)
        {
            return db.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario Find(string login, string senha)
        {
            return db.Usuarios.FirstOrDefault(u => u.login == login && u.senha == senha);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return db.Usuarios.ToList();
        }

        public void Remove(long id)
        {
            var entity = db.Usuarios.First(u=> u.Id == id);
            db.Usuarios.Remove(entity);
            db.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            db.Usuarios.Update(usuario);
            db.SaveChanges();
        }
    }
}