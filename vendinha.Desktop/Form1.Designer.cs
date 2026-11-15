using vendinha.Desktop.Components;

namespace vendinha.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new PrimaryButton();
            labelTitulo1 = new LabelTitulo();
            labelTitulo2 = new LabelTitulo();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(279, 277);
            button1.Name = "button1";
            button1.Size = new Size(220, 60);
            button1.TabIndex = 0;
            button1.Text = "Acessar Sistema";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo1.Location = new Point(102, 49);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(573, 86);
            labelTitulo1.TabIndex = 1;
            labelTitulo1.Text = "Sistema Vendinha";
            // 
            // labelTitulo2
            // 
            labelTitulo2.AutoSize = true;
            labelTitulo2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo2.Location = new Point(216, 363);
            labelTitulo2.Name = "labelTitulo2";
            labelTitulo2.Size = new Size(345, 32);
            labelTitulo2.TabIndex = 2;
            labelTitulo2.Text = "Clique no botão para acessar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTitulo2);
            Controls.Add(labelTitulo1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrimaryButton button1;
        private LabelTitulo labelTitulo1;
        private LabelTitulo labelTitulo2;
    }
}
