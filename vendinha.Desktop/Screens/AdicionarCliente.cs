using vendinha.Models;
using vendinha.Services;

namespace vendinha.Desktop.Screens
{
    public partial class AdicionarCliente : Form
    {
        private readonly ClienteService service;
        public AdicionarCliente(ClienteService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void primaryButton1_Click(object sender, object e)
        {
            var cliente = new Cliente
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                DataNascimento = txtDataNascimento.Value.Date.ToUniversalTime(),
                Email = txtEmail.Text
            };

            var sucesso = service.Criar(cliente, out var erros);

            if (sucesso)
            {
                MessageBox.Show("Cliente adicionado!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(erros[0].ErrorMessage);
            }
        }
    }
}
