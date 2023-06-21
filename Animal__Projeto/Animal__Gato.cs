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
    public partial class Animal__Gato : Form
    {
        Mamifero__Classe gato1 = new Mamifero__Classe();

        public Animal__Gato()
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

            nome = inputName2.Text;
            cor = inputColor2.Text;
            raca = inputRace2.Text;
            peso = Convert.ToDouble(inputWeight2.Text);

            gato1.Nome = nome;
            gato1.Cor = cor;
            gato1.Raca = raca;
            gato1.Peso = peso;

            if (gato1.Nome != null)
            {
                MessageBox.Show("Gato Criado", "Mamífero | Gato");
            }
            else
            {
                MessageBox.Show("Inválido");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + gato1.Nome + "\n" +
                            "Pesos: " + gato1.Peso + "\n" +
                            "Raça: " + gato1.Raca + "\n" +
                            "Cor: " + gato1.Cor, "Mamífero | Gato");
        }

        private void inputRace2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
