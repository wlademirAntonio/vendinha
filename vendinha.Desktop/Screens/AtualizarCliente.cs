using vendinha.Models;
using vendinha.Services;

namespace vendinha.Desktop.Screens
{
    public partial class AtualizarCliente : Form
    {
        private readonly ClienteService service;
        private readonly Cliente cliente;
        public AtualizarCliente(ClienteService service, Cliente cliente)
        {
            this.service = service;
            this.cliente = cliente;
            InitializeComponent(cliente);
        }

        private void primaryButton1_Click(object sender, object e)
        {
            var cliente = new Cliente
            {
                Id = this.cliente.Id,
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                DataNascimento = txtDataNascimento.Value.Date.ToUniversalTime(),
                Email = txtEmail.Text
            };

           
            var sucesso = service.Atualizar(cliente, out var erros);

            if (sucesso)
            {
                MessageBox.Show("Cliente Atualizado!");
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
