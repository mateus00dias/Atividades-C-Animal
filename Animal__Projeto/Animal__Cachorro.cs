using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal__Projeto
{
    public partial class Animal__Cachorro : Form
    {
        Mamifero__Classe cachorro1 = new Mamifero__Classe();

        public Animal__Cachorro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome;
            string cor;
            string raca;
            double peso;

            nome = inputName.Text;
            cor = inputColor.Text;
            raca = inputRace.Text;
            peso = Convert.ToDouble(inputWeight.Text);

            cachorro1.Nome = nome;
            cachorro1.Cor = cor;
            cachorro1.Peso = peso;
            cachorro1.Raca = raca;

            if (cachorro1.Nome != null)
            {
                MessageBox.Show("Cachorro Criado");
            }else
            {
                MessageBox.Show("Inválido");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + cachorro1.Nome + "\n" +
                            "Pesos: " + cachorro1.Peso + "\n" +
                            "Raça: " + cachorro1.Raca + "\n" +
                            "Cor: " + cachorro1.Cor);
        }
    }
}
