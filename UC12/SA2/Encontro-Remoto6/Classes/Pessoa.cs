using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto6.Interfaces;


namespace encontro_remoto6.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }
        public Endereco? endereco { get; set; }

        public float rendimento { get; set; }
        public abstract float CalcularImposto(float rendimento);

    }
}