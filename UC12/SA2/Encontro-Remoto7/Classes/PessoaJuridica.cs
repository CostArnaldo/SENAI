using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using encontro_remoto7.Interfaces;

namespace encontro_remoto7.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public long cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return (rendimento * 0.03f);
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return (rendimento * 0.05f);
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return (rendimento * 0.07f);
            }
            else
            {
                return (rendimento * 0.09f);
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido= Regex.IsMatch(cnpj, @"(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

    // CNPJ não pode ser diferente de 14 dígitos,0
    if (cnpj.Length != 14)
    {
        return false;
    }

    // Calcula o primeiro dígito verificador
    int soma = 0;
    int peso = 2;

    for (int i = 11; i >= 0; i--)
    {
        /*o número do CNPJ a ser verificado. "Parse" p/ transformar em número inteiro e "ToString" p/ transformar em String.*/
        int num = int.Parse(cnpj[i].ToString());
        //"soma" sendo somada a cada loop.
        soma += num * peso;
        
        /*peso vai até 9 e depois voltará a ser igual a "2"*/
        if (peso == 9)
        {
            peso = 2;
        }
        else
        {
            peso++;
        }
    }
        //soma divido por 11 e o valor que sobrar é o valor da variavel "resto"
    int resto = soma % 11;
    //se resto for menor que "2" então o digito é 0. Se for =< 2, então é 11-resto"
    int dv1 = resto < 2 ? 0 : 11 - resto;

    // Calcula o segundo dígito verificador
    soma = 0;
    peso = 2;

    for (int i = 12; i >= 0; i--)
    {
        int num = int.Parse(cnpj[i].ToString());
        soma += num * peso;

        if (peso == 9)
        {
            peso = 2;
        }
        else
        {
            peso++;
        }
    }

    resto = soma % 11;
    int dv2 = resto < 2 ? 0 : 11 - resto;

    // Verifica se os dígitos verificadores são válidos. "Parse" para converter os dois ultimos números em números inteiros.
    if (int.Parse(cnpj[12].ToString()) == dv1 && int.Parse(cnpj[13].ToString()) == dv2)
    {
        return true;
    }

    return false;
}

        }
    }
