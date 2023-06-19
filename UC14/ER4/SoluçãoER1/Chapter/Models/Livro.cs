using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter.Models
{
public class Livro
{
    public int Id { get; set; }
        
    public string Titulo { get; set; }

    public int QuantidadePaginas { get; set; }

    public bool Disponivel { get; set; }
}
}
