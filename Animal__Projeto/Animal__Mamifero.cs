using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Animal__Projeto
{
    public partial class Animal__Mamifero : Form
    {
        Mamifero__Classe gato1 = new Mamifero__Classe();

        public Animal__Mamifero()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal__Cachorro tela = new Animal__Cachorro();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal__Gato tela = new Animal__Gato();
            tela.ShowDialog();
        }
    }
}
