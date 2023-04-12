using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto3.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string Cnpj);
    }
}