using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Projeto
{
    internal class Animal__Classe
    {
        string nome;
        string raca;
        double peso;
        string cor;


        public Animal__Classe()
        {

        }

        public Animal__Classe(string nome, string raca, string cor, double peso)
        {
            this.Nome = nome;
            this.Peso = peso;
            this.Raca = raca;
            this.Cor = cor;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Raca { get => raca; set => raca = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
