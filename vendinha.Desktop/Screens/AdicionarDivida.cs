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
    public partial class AdicionarDivida : Form
    {
        private readonly DividaService service;
        private Cliente cliente;
        public AdicionarDivida(DividaService service, Cliente cliente)
        {
            this.service = service;
            this.cliente = cliente;
            InitializeComponent();
        }
    }
}
