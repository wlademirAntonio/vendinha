using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using vendinha.Models;
using vendinha.Services;

namespace vendinha.Desktop.Screens
{
    public partial class Clientes : Form
    {
        private ClienteService service = new ClienteService();
        public Clientes()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void ExibirDados()
        {
            var clientes = service.Listar();
            ExibirTabela(clientes);
        }

        private void ExibirTabela(List<Cliente> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var cliente in lista)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.DataNascimento.ToString("dd/MM/yyyy"),
                    cliente.Email
                    );

                dataGridView1.Rows[rowIndex].Tag = cliente;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void primaryButton1_Click(object sender, EventArgs e)
        {
            using (var tela = new AdicionarCliente(service))
            {
                if (tela.ShowDialog() == DialogResult.OK)
                {
                    ExibirDados();
                }
            }
        }

        private void primaryButton2_Click(object sender, EventArgs e)
        {
            var clienteSelecionado = dataGridView1.CurrentRow.Tag as Cliente;

            using (var tela = new AtualizarCliente(service, clienteSelecionado))
            {
                if (tela.ShowDialog() == DialogResult.OK)
                {
                    ExibirDados();
                }
            }
        }
    }
}
