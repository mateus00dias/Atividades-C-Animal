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
    public partial class Animal__Oviparo : Form
    {
        public Animal__Oviparo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal__Galinha tela = new Animal__Galinha();
            tela.ShowDialog();
        }
    }
}
