

using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
public class SqlContext : DbContext
{
    public SqlContext() { }
    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
            optionsBuilder.UseSqlServer();

            // Exemplo 1 de string de conexão:
            // User ID=sa; Password=admin; Server=localhost; Database=Chapter;-
            // + Trusted_Connection = false;
            // Exemplo 2 de string de conexão:
            //Data Source=SQL_NOLD\\SQLEXPRESS;Initial catalog=Chapter;Integrated Security=true
            //Server = localhost\\SQLEXPRESS; Database=Chapter; Trusted_Connection = True;
            
    }
    public DbSet<Livro> Livros { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }


}
}
