using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto4.Interfaces;

namespace encontro_remoto4.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public long cpf { get; set; }

        public DateTime dataN { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento * 0.02f);
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento * 0.035f);
            }
            else
            {
                return (rendimento * 0.05f);
            }
        }

        public bool ValidarDataN(DateTime dataN)
        {
            DateTime dataAtual = DateTime.Today;

            double idade = (dataAtual - dataN).TotalDays / 365;

            if (idade >= 18)
            {
                return true; 
            }
           
            return false;

        }
        public bool ValidarDataN(string dataN)
        {
            if (DateTime.TryParse(dataN, out DateTime dataCon)){
                DateTime dataAtual = DateTime.Today;

            double idade = (dataAtual - dataCon).TotalDays / 365;

            if (idade >= 18)
            {
                return true;
            }
            

            };
            return false;
        }

    }
}
