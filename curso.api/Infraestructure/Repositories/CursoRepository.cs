using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using curso.api.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace curso.api.Infraestructure.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _context;

        public CursoRepository(CursoDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Curso curso)
        {
            _context.Curso.Add(curso);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Curso> ObterPorUsuario(int codigoUsuario)
        {
            return _context.Curso
                .Include(x => x.Usuario)
                .Where(x => x.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}
