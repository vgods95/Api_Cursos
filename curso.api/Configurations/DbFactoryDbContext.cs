using curso.api.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace curso.api.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(@"Server=ACCOUNT-VINICIU\SQLEXPRESS;Database=API_CURSO;Initial Catalog=API_CURSO;Integrated Security=True;Trusted_Connection=True;");
            return new CursoDbContext(optionsBuilder.Options);
        }
    }
}
