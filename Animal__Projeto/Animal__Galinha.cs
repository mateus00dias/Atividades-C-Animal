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
    public partial class Animal__Galinha : Form
    {
        Ovíparo__Classe galinha1 = new Ovíparo__Classe();

        public Animal__Galinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string raça;
            double peso;
            string espécie;

            raça = inputRace.Text;
            espécie = inputE.Text;
            peso = Convert.ToDouble(inputWeight.Text);

            galinha1.Raça = raça;
            galinha1.Espécie = espécie;
            galinha1.Peso = peso;

            if (galinha1.Raça != null)
            {
                MessageBox.Show("Galinha Criada", "Ovíparo | Galinha");
            }
            else
            {
                MessageBox.Show("Inválido", "Ovíparo | Galinha");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Peso: " + galinha1.Peso + "\n" +
                            "Espécie: " + galinha1.Espécie + "\n" +
                            "Raça: " + galinha1.Raça + "\n", "Ovíparo | Galinha");
        }
    }
}
