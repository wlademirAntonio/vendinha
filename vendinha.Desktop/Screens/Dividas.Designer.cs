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
            label1 = new vendinha.Desktop.Components.LabelTitulo();
            labelTitulo1 = new vendinha.Desktop.Components.LabelTitulo();
            primaryButton1 = new vendinha.Desktop.Components.PrimaryButton();
            primaryButton2 = new vendinha.Desktop.Components.PrimaryButton();
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
            dataGridView1.Location = new Point(104, 132);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(104, 32);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 2;
            label1.Text = "Dividas de:";
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitulo1.Location = new Point(112, 78);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(186, 37);
            labelTitulo1.TabIndex = 3;
            labelTitulo1.Text = "Fulano de Tal";
            // 
            // primaryButton1
            // 
            primaryButton1.BackColor = Color.DarkGreen;
            primaryButton1.FlatAppearance.BorderSize = 0;
            primaryButton1.FlatStyle = FlatStyle.Flat;
            primaryButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            primaryButton1.ForeColor = Color.White;
            primaryButton1.Location = new Point(556, 361);
            primaryButton1.Name = "primaryButton1";
            primaryButton1.Size = new Size(140, 40);
            primaryButton1.TabIndex = 4;
            primaryButton1.Text = "Adicionar";
            primaryButton1.UseVisualStyleBackColor = false;
            primaryButton1.Click += primaryButton1_Click;
            // 
            // primaryButton2
            // 
            primaryButton2.BackColor = Color.Orange;
            primaryButton2.FlatAppearance.BorderSize = 0;
            primaryButton2.FlatStyle = FlatStyle.Flat;
            primaryButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            primaryButton2.ForeColor = Color.White;
            primaryButton2.Location = new Point(367, 361);
            primaryButton2.Name = "primaryButton2";
            primaryButton2.Size = new Size(183, 40);
            primaryButton2.TabIndex = 5;
            primaryButton2.Text = "Marcar Pagamento";
            primaryButton2.UseVisualStyleBackColor = false;
            primaryButton2.Click += primaryButton2_Click;
            // 
            // Dividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(primaryButton2);
            Controls.Add(primaryButton1);
            Controls.Add(labelTitulo1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Dividas";
            Text = "Dividas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn DataPagamento;
        private Components.LabelTitulo label1;
        private Components.LabelTitulo labelTitulo1;
        private Components.PrimaryButton primaryButton1;
        private Components.PrimaryButton primaryButton2;
    }
}