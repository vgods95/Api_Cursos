using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using curso.api.Infraestructure.Data;

namespace curso.api.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CursoDbContext _context;

        public UsuarioRepository(CursoDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Usuario ObterUsuario(string login)
        {
            return _context.Usuario.FirstOrDefault(u => u.Login == login);
        }
    }
}
