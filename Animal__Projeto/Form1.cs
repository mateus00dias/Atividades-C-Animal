namespace Animal__Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal__Mamifero tela = new Animal__Mamifero();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal__Oviparo tela = new Animal__Oviparo();
            tela.ShowDialog();
        }
    }
}