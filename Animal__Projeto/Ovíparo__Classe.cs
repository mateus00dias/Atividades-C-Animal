using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Projeto
{
    internal class Ovíparo__Classe
    {
        string raça;
        double peso;
        string espécie;

        public Ovíparo__Classe()
        {

        }

        public Ovíparo__Classe(string raça, double peso, string espécie)
        {
            this.Raça = raça;
            this.Peso = peso;
            this.Espécie = espécie;
        }

        public string Raça { get => raça; set => raça = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Espécie { get => espécie; set => espécie = value; }
    }
}
