using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
public class LivroRepository
{
    private readonly SqlContext _context;

    public LivroRepository(SqlContext context)
    {
        _context = context;
    }

    public List<Livro> Listar()
    {
        return _context.Livros.ToList();
    }

    public Livro BuscarPorId(int id)
    {
        return _context.Livros.Find(id);
    }

    public void Cadastrar(Livro li)
    {
        _context.Livros.Add(li);
        _context.SaveChanges();
    }

    public void Atualizar(int id, Livro li)
    {
        Livro livroBuscado = _context.Livros.Find(id);

        if (livroBuscado != null)
        {
            livroBuscado.Titulo = li.Titulo;
            livroBuscado.Disponivel = li.Disponivel;
            livroBuscado.QuantidadePaginas = li.QuantidadePaginas;

            _context.Livros.Update(livroBuscado);

            _context.SaveChanges();
        }
    }

    public void Excluir(int id)
    {
        Livro li = _context.Livros.Find(id);
        _context.Livros.Remove(li);
        _context.SaveChanges();
    }

}
}
