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
        public int page = 1;
        public Clientes()
        {
            InitializeComponent();
            ExibirDados();
        }

        private int ExibirDados()
        {
            var clientes = service.Listar(pesquisa.Text, page);
            ExibirTabela(clientes);

            var proximaPag = service.Listar(pesquisa.Text, page + 1);
            return proximaPag.Count;
        }

        private void ExibirTabela(List<Cliente> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var cliente in lista)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    cliente.Nome,
                    cliente.Idade,
                    cliente.Cpf,
                    cliente.Email ?? "",
                    cliente.TotalDividas
                    );

                dataGridView1.Rows[rowIndex].Tag = cliente;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clienteSelecionado = dataGridView1.CurrentRow?.Tag as Cliente;

            using (var tela = new Dividas(clienteSelecionado))
            {
                tela.ShowDialog();
                ExibirDados();
            }
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
            var clienteSelecionado = dataGridView1.CurrentRow?.Tag as Cliente;

            using (var tela = new AtualizarCliente(service, clienteSelecionado))
            {
                if (tela.ShowDialog() == DialogResult.OK)
                {
                    ExibirDados();
                }
            }
        }

        private void primaryButton3_Click(object sender, EventArgs e)
        {
            var clienteSelecionado = dataGridView1.CurrentRow?.Tag as Cliente;

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este cliente?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                var sucesso = service.Excluir(clienteSelecionado, out var erros);

                if (sucesso)
                {
                    MessageBox.Show("Cliente excluído!");
                    ExibirDados();
                }
                else
                {
                    MessageBox.Show(erros[0].ErrorMessage);
                }
            }
            else
                MessageBox.Show("Exclusão cancelada.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExibirDados() > 0)
            {
                page += 1;
                ExibirDados();
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page -= 1;
                ExibirDados();
            }
        }

        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            page = 1;
            ExibirDados();
        }
    }
}