using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using vendinha.Models;
using vendinha.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vendinha.Desktop.Screens
{
    public partial class Dividas : Form
    {
        private DividaService service = new DividaService();
        private Cliente cliente;
        public Dividas(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent(cliente);
            ExibirDados();
        }

        private int ExibirDados()
        {
            var dividas = service.Listar(cliente.Id);
            ExibirTabela(dividas);

            var proximaPag = service.Listar(cliente.Id);
            return proximaPag.Count;
        }

        private void ExibirTabela(List<Divida> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var divida in lista)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    divida.DataCriacao.ToString("dd/MM/yyyy"),
                    divida.Valor,
                    divida.Pago ? "Pago" : "Em aberto",
                    divida.DataPagamento?.ToString("dd/MM/yyyy") ?? ""
                    );

                dataGridView1.Rows[rowIndex].Tag = divida;
            }
        }

        private void primaryButton1_Click(object sender, object e)
        {

            if (decimal.TryParse(inputNovaDivida.Text, out decimal valor))
            {
                var divida = new Divida
                {
                    ClienteId = cliente.Id,
                    Valor = valor
                };

                DialogResult resultado = MessageBox.Show(
                    "Deseja pendurar uma nova divida para este cliente?",
                    cliente.Nome,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                if (resultado == DialogResult.Yes)
                {
                    var sucesso = service.Criar(divida, out var erros);

                    if (sucesso)
                    {
                        MessageBox.Show("Divida pendurada!");
                        ExibirDados();
                    }
                    else
                        MessageBox.Show(erros[0].ErrorMessage);
                }
                else
                    MessageBox.Show("Divida não adicionada.");
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }
        }

        private void primaryButton2_Click(object sender, EventArgs e)
        {
            var dividaSelecionada = dataGridView1.CurrentRow?.Tag as Divida;

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja marcar essa divida como paga?",
                "Confirmar Pagamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                var sucesso = service.Pagar(dividaSelecionada, out var erros);

                if (sucesso)
                {
                    MessageBox.Show("Divida paga!");
                    ExibirDados();
                }
                else
                    MessageBox.Show(erros[0].ErrorMessage);
            }
            else
                MessageBox.Show("Pagamento cancelado.");
        }
    }
}
