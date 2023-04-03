using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto2.Interfaces;

namespace encontro_remoto2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public int Cnpj {get; set;}
        
        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string Cnpj){
            throw new NotImplementedException();
        }
    }
}