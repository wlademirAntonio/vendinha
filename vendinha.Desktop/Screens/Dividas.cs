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
            InitializeComponent();
            ExibirDados();
        }

        private int ExibirDados()
        {
            var dividas = service.Listar(clienteId: cliente.Id);
            ExibirTabela(dividas);

            var proximaPag = service.Listar(clienteId: cliente.Id);
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
    }
}
