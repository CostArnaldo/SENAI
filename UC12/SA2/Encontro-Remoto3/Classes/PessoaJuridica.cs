using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto3.Interfaces;

namespace encontro_remoto3.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public int Cnpj {get; set;}
        
        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000) {
                return (rendimento * 0.03f);
            } else if (rendimento > 3000 && rendimento <=6000) {
                return (rendimento * 0.05f);
            } else if (rendimento > 6000 && rendimento <=10000) {
                return (rendimento * 0.07f);
            } else {
                return (rendimento * 0.09f);
            } 
        }

        public bool ValidarCnpj(string Cnpj){
            throw new NotImplementedException();
        }
    }
}