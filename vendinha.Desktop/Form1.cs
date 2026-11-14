using vendinha.Desktop.Screens;

namespace vendinha.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tela = new Clientes();
            tela.ShowDialog();
        }

        private void primaryButton1_Click(object sender, EventArgs e)
        {
            var tela = new Dividas();
            tela.ShowDialog();
        }
    }
}
