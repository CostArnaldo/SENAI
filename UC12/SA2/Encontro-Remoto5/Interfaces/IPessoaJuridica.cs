using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto5.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpj);
    }
}