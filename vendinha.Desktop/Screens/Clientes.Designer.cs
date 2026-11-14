using vendinha.Desktop.Components;

namespace vendinha.Desktop.Screens
{
    partial class Clientes
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
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label1 = new LabelTitulo();
            primaryButton1 = new PrimaryButton();
            primaryButton2 = new PrimaryButton();
            primaryButton3 = new PrimaryButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Cpf, DataNascimento, Email });
            dataGridView1.Location = new Point(107, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.Size = new Size(592, 223);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            // 
            // DataNascimento
            // 
            DataNascimento.HeaderText = "Data de Nascimento";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(254, 30);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 1;
            label1.Text = "Gerenciar Clientes";
            // 
            // primaryButton1
            // 
            primaryButton1.BackColor = Color.DarkGreen;
            primaryButton1.FlatAppearance.BorderSize = 0;
            primaryButton1.FlatStyle = FlatStyle.Flat;
            primaryButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            primaryButton1.ForeColor = Color.White;
            primaryButton1.Location = new Point(559, 359);
            primaryButton1.Name = "primaryButton1";
            primaryButton1.Size = new Size(140, 40);
            primaryButton1.TabIndex = 2;
            primaryButton1.Text = "Adicionar";
            primaryButton1.UseVisualStyleBackColor = false;
            primaryButton1.Click += primaryButton1_Click;
            // 
            // primaryButton2
            // 
            primaryButton2.BackColor = Color.DarkBlue;
            primaryButton2.FlatAppearance.BorderSize = 0;
            primaryButton2.FlatStyle = FlatStyle.Flat;
            primaryButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            primaryButton2.ForeColor = Color.White;
            primaryButton2.Location = new Point(453, 359);
            primaryButton2.Name = "primaryButton2";
            primaryButton2.Size = new Size(100, 40);
            primaryButton2.TabIndex = 3;
            primaryButton2.Text = "Editar";
            primaryButton2.UseVisualStyleBackColor = false;
            primaryButton2.Click += primaryButton2_Click;
            // 
            // primaryButton3
            // 
            primaryButton3.BackColor = Color.DarkRed;
            primaryButton3.FlatAppearance.BorderSize = 0;
            primaryButton3.FlatStyle = FlatStyle.Flat;
            primaryButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            primaryButton3.ForeColor = Color.White;
            primaryButton3.Location = new Point(347, 359);
            primaryButton3.Name = "primaryButton3";
            primaryButton3.Size = new Size(100, 40);
            primaryButton3.TabIndex = 4;
            primaryButton3.Text = "Excluir";
            primaryButton3.UseVisualStyleBackColor = false;
            primaryButton3.Click += primaryButton3_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(primaryButton3);
            Controls.Add(primaryButton2);
            Controls.Add(primaryButton1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Email;
        private LabelTitulo label1;
        private PrimaryButton primaryButton1;
        private PrimaryButton primaryButton2;
        private PrimaryButton primaryButton3;
    }
}