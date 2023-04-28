using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto7.Interfaces;

namespace encontro_remoto7.Classes
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

        public bool ValidarCPF(long cpf) {
    int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

    string cpfString = cpf.ToString("D11");

    if (cpfString.Length != 11) 
        return false;

    int soma = 0;
    for (int i = 0; i< 9; i++)
        soma += int.Parse(cpfString[i].ToString()) * multiplicadores1[i];

    int primeiroDigito = 11 - soma % 11;
    primeiroDigito = primeiroDigito > 9 ? 0 : primeiroDigito;

    soma = 0;
    for (int i = 0; i< 10; i++)
        soma += int.Parse(cpfString[i].ToString()) * multiplicadores2[i];

    int segundoDigito = 11 - soma % 11;
    segundoDigito = segundoDigito > 9 ? 0 : segundoDigito;

    return cpfString.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
}
    }
}
