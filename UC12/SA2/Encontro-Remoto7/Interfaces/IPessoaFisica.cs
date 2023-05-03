using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto7.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataN(DateTime dataN);

        bool ValidarCPF(long cpf);
    }
    
}