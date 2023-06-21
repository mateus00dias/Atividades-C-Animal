using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Projeto
{
    internal class Mamifero__Classe : Animal__Classe
    {
        public Mamifero__Classe() : base()
        {

        }

        public Mamifero__Classe(string nome, string raca, string cor, double peso) : base(nome, raca, cor, peso)
        {
            this.Nome = nome;
            this.Cor = cor;
            this.Raca = raca;
            this.Peso = peso;
        }
    }
}

