namespace vendinha.Desktop.Screens
{
    partial class Dividas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            DataCriacao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            DataPagamento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataCriacao, Valor, Situacao, DataPagamento });
            dataGridView1.Location = new Point(104, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.Size = new Size(592, 223);
            dataGridView1.TabIndex = 1;
            // 
            // DataCriacao
            // 
            DataCriacao.HeaderText = "Criação";
            DataCriacao.Name = "DataCriacao";
            DataCriacao.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Situacao
            // 
            Situacao.HeaderText = "Situação";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            // 
            // DataPagamento
            // 
            DataPagamento.HeaderText = "Data do Pagamento";
            DataPagamento.Name = "DataPagamento";
            DataPagamento.ReadOnly = true;
            // 
            // Dividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Dividas";
            Text = "Dividas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn DataPagamento;
    }
}