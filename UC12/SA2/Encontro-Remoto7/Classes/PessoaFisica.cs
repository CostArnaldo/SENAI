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

        public bool ValidarCPF(long cpf)
        {
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            
            // CPF convertido para uma string de 11 caracteres
            string cpfString = cpf.ToString("D11");
            // CPf não pode ser diferente de 11 dígitos
            if (cpfString.Length != 11)
                return false;
            // Calcula o primeiro dígito verificador
            int soma = 0;
            // soma os primeiros 9 dígitos do CPF e multiplica pelos valores dos pesos contidos no array multiplicadores1.
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpfString[i].ToString()) * multiplicadores1[i];
            // O resultado dessa soma é dividido por 11 e o resto da divisão é subtraído de 11 para se obter o valor do primeiro dígito verificador.
            int primeiroDigito = 11 - soma % 11;
            //Se o valor do primeiro dígito verificador for maior do que 9, ele é substituído por 0.
            primeiroDigito = primeiroDigito > 9 ? 0 : primeiroDigito;
            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfString[i].ToString()) * multiplicadores2[i];

            int segundoDigito = 11 - soma % 11;
            segundoDigito = segundoDigito > 9 ? 0 : segundoDigito;
            // função concatena os valores do primeiro e segundo dígitos verificadores em uma string. 
            // Também verifica se essa string é igual aos dois últimos dígitos do CPF original.
            return cpfString.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
        }

    }
}
