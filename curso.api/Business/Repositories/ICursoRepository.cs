using curso.api.Business.Entities;

namespace curso.api.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        void Commit();
        List<Curso> ObterPorUsuario(int codigoUsuario);
    }
}
