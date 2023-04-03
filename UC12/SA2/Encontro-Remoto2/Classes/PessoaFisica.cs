using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto2.Interfaces;

namespace encontro_remoto2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public int cpf {get; set;}

        public DateTime dataN {get; set;}

        public override float CalcularImposto(float rendimento){
            throw new NotImplementedException();
        }
        public bool ValidarDataN(DateTime dataN){
            throw new NotImplementedException();
        }
    }
}