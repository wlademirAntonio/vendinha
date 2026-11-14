using vendinha.Models;

namespace vendinha.Desktop.Screens
{
    partial class AtualizarCliente
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
        private void InitializeComponent(Cliente cliente)
        {
            labelTitulo1 = new vendinha.Desktop.Components.LabelTitulo();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtDataNascimento = new DateTimePicker();
            primaryButton1 = new vendinha.Desktop.Components.PrimaryButton();
            SuspendLayout();
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            labelTitulo1.Location = new Point(206, 41);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(380, 46);
            labelTitulo1.TabIndex = 0;
            labelTitulo1.Text = "Atualizar cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(245, 140);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 23);
            txtNome.TabIndex = 1;
            //txtNome.Text = cliente.Nome;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(245, 122);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(245, 182);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(245, 200);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(159, 23);
            txtCpf.TabIndex = 3;
            //txtCpf.Text = cliente.Cpf;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(410, 182);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 6;
            label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(245, 251);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Email (Opcional)";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(245, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 23);
            txtEmail.TabIndex = 7;
            //txtEmail.Text = cliente.Email;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Format = DateTimePickerFormat.Short;
            txtDataNascimento.Location = new Point(410, 200);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(146, 23);
            txtDataNascimento.TabIndex = 9;
            //txtDataNascimento.Value = cliente.DataNascimento.ToLocalTime();
            // 
            // primaryButton1
            // 
            primaryButton1.BackColor = Color.Orange;
            primaryButton1.FlatAppearance.BorderSize = 0;
            primaryButton1.FlatStyle = FlatStyle.Flat;
            primaryButton1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            primaryButton1.ForeColor = Color.White;
            primaryButton1.Location = new Point(291, 325);
            primaryButton1.Name = "primaryButton1";
            primaryButton1.Size = new Size(220, 60);
            primaryButton1.TabIndex = 10;
            primaryButton1.Text = "Adicionar";
            primaryButton1.UseVisualStyleBackColor = false;
            primaryButton1.Click += primaryButton1_Click;
            // 
            // AdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(primaryButton1);
            Controls.Add(txtDataNascimento);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(this.txtCpf);
            Controls.Add(label1);
            Controls.Add(this.txtNome);
            Controls.Add(labelTitulo1);
            Name = "AdicionarCliente";
            Text = "AdicionarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.LabelTitulo labelTitulo1;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private DateTimePicker txtDataNascimento;
        private Components.PrimaryButton primaryButton1;
    }
}